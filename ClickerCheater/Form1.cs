using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ClickerCheater
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const int HOTKEY_ID = 1;
        private const uint VK_F6 = 0x75;

        private int clickCount = 0;
        private bool isRunning = false;
        private Thread? clickThread;
        private readonly object lockObject = new object();

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, VK_F6);
            this.TopMost = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                if (isRunning)
                {
                    StopClicking();
                }
                else
                {
                    StartClicking();
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopClicking();
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopClicking();
        }

        private void StartClicking()
        {
            lock (lockObject)
            {
                if (!isRunning)
                {
                    isRunning = true;
                    
                    UpdateStatus("Running", Color.Green);
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    numInterval.Enabled = false;

                    clickThread = new Thread(ClickLoop)
                    {
                        IsBackground = true,
                        Priority = ThreadPriority.Highest
                    };
                    clickThread.Start();
                }
            }
        }

        private void StopClicking()
        {
            lock (lockObject)
            {
                if (isRunning)
                {
                    isRunning = false;
                    clickThread?.Join(1000);
                    
                    UpdateStatus("Stopped", Color.Red);
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    numInterval.Enabled = true;
                }
            }
        }

        private void ClickLoop()
        {
            Stopwatch sw = Stopwatch.StartNew();
            double intervalMilliseconds = 0;
            int updateCounter = 0;
            int localClickCount = 0;

            Invoke(() => intervalMilliseconds = (double)numInterval.Value);

            while (isRunning)
            {
                // 1 millisecond = 10000 ticks in .NET Stopwatch
                long targetTicks = (long)(intervalMilliseconds * 10000);
                long startTicks = sw.ElapsedTicks;

                Point cursorPos = Cursor.Position;
                mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);

                localClickCount++;
                updateCounter++;

                if (updateCounter >= 50)
                {
                    updateCounter = 0;
                    int currentCount = localClickCount;
                    try
                    {
                        Invoke(() => 
                        {
                            clickCount += currentCount;
                            lblClickCount.Text = $"Total Clicks: {clickCount:N0}";
                        });
                        localClickCount = 0;
                    }
                    catch { }
                }

                while (sw.ElapsedTicks - startTicks < targetTicks && isRunning)
                {
                    Thread.SpinWait(10);
                }
            }

            // Final update
            try
            {
                Invoke(() => 
                {
                    clickCount += localClickCount;
                    lblClickCount.Text = $"Total Clicks: {clickCount:N0}";
                });
            }
            catch { }
        }

        private void UpdateStatus(string status, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateStatus(status, color));
                return;
            }
            lblStatus.Text = $"Status: {status}";
            lblStatus.ForeColor = color;
        }

        private void clickTimer_Tick(object sender, EventArgs e)
        {
            // Not used anymore, kept for compatibility
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // This is kept as a backup for when the form has focus
            if (e.KeyCode == Keys.F6)
            {
                e.Handled = true;
            }
        }
    }
}
