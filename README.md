# ClickerCheater

A high-performance auto-clicker application for Windows, designed primarily for Cookie Clicker and similar idle/clicker games. Built with .NET 8.0 and Windows Forms.

## 🎯 What is ClickerCheater?

ClickerCheater is an automated mouse clicking tool that simulates rapid mouse clicks at customizable intervals. It features a simple, user-friendly interface with global hotkey support, allowing you to automate clicking without manually interacting with your mouse.

### Key Features

- **Configurable Click Speed**: Set click intervals from 1ms to 100,000ms
- **Global Hotkey Support**: Press F6 to start/stop clicking from anywhere (even when the window is minimized or in the background)
- **High Performance**: Uses high-priority threading and precise timing for accurate click intervals
- **Click Counter**: Tracks total number of clicks performed
- **Always on Top**: Window stays on top of other applications for easy access
- **Real-time Status**: Visual feedback showing current running status

## 🖥️ System Requirements

- **Operating System**: Windows (Windows 10 or later recommended)
- **.NET Runtime**: .NET 8.0 Desktop Runtime or later
- **Architecture**: x64 or x86

## 🚀 Getting Started

### Installation

1. Download the latest release from the [Releases](../../releases) page
2. Extract the ZIP file to your desired location
3. Run `ClickerCheater.exe`

### Building from Source

```bash
# Clone the repository
git clone https://github.com/PizzaDumpster/ClickerCheater.git

# Navigate to the project directory
cd ClickerCheater

# Build the project
dotnet build ClickerCheater.sln

# Run the application
dotnet run --project ClickerCheater/ClickerCheater.csproj
```

## 📖 Usage

1. **Set Click Interval**: Enter the desired interval between clicks in milliseconds (default: 100ms)
2. **Start Clicking**: 
   - Click the "Start (F6)" button, OR
   - Press F6 on your keyboard (works globally)
3. **Stop Clicking**: 
   - Click the "Stop (F6)" button, OR
   - Press F6 again to toggle off
4. **Monitor Progress**: Watch the status indicator and click counter update in real-time

### Hotkeys

- **F6**: Toggle auto-clicking on/off (works globally, even when application is not in focus)

### Tips

- Set the click interval according to your needs (lower values = faster clicking)
- The application window stays on top of other windows by default for easy access
- The click counter displays the total number of clicks performed during the session
- Clicks are performed at the current mouse cursor position

## ⚙️ Technical Details

- **Language**: C#
- **Framework**: .NET 8.0 with Windows Forms
- **Threading**: High-priority background thread for click execution
- **Timing**: Stopwatch-based precision timing for accurate intervals
- **Mouse Events**: Win32 API (`user32.dll`) for mouse event simulation
- **Hotkey Registration**: Win32 API global hotkey registration

## ⚠️ Disclaimer

This tool is intended for educational and entertainment purposes. Use responsibly and in accordance with the terms of service of any games or applications you use it with. The authors are not responsible for any consequences resulting from the use of this software, including but not limited to:

- Account bans or suspensions in online games
- Violation of terms of service
- Unintended actions caused by automated clicking

**Use at your own risk.**

## 📄 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## 🤝 Contributing

Contributions are welcome! Feel free to:

- Report bugs or issues
- Suggest new features
- Submit pull requests

## 📝 Notes

- The application automatically cleans up resources (unregisters hotkeys, stops threads) when closed
- The window has a fixed size and centered position for consistent user experience
- Click events are thread-safe with proper synchronization