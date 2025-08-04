# Contributing to WUPHF App

Welcome to the WUPHF project! This guide will help you get set up to contribute to Ryan Howard's revolutionary communication platform.

## 🚀 Quick Start

### Prerequisites

#### Required Software
- **.NET 9.0 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/9.0)
- **Visual Studio 2022** (recommended) or **Visual Studio Code**
- **Git** for version control

#### Platform-Specific Requirements

**For Windows Development (Recommended):**
- Windows 10 version 1809 (build 17763) or later
- Windows 11 (preferred)
- Visual Studio 2022 with the ".NET Multi-platform App UI development" workload

**For Cross-Platform Development:**
- **Android**: Android SDK, Android API 24 or later
- **iOS**: macOS with Xcode 15.0 or later
- **macOS**: Xcode 15.0 or later on a Mac

### Installation Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/DunderMifflinPaperCompany/WUPHFApp.git
   cd WUPHFApp
   ```

2. **Install .NET MAUI workload:**
   ```bash
   dotnet workload install maui
   ```

3. **Restore NuGet packages:**
   ```bash
   dotnet restore
   ```

4. **Build the project:**
   ```bash
   # For Windows only
   dotnet build --framework net9.0-windows10.0.19041.0

   # For all platforms (requires platform SDKs)
   dotnet build
   ```

## 🔧 Development Setup

### Recommended IDE Setup

**Visual Studio 2022:**
- Install the "Mobile development with .NET" workload
- Install the "ASP.NET and web development" workload
- Install the MAUI extension

**Visual Studio Code:**
- Install the C# extension
- Install the .NET MAUI extension
- Install the Blazor extension

### Project Structure

```
WUPHFApp/
├── Components/
│   ├── Layout/           # App layout components
│   └── Pages/            # Blazor pages (Dashboard, Compose, Demo, etc.)
├── Data/                 # Sample data (Office characters)
├── Models/               # Data models (WuphfMessage, WuphfContact, etc.)
├── Resources/            # App resources (images, fonts, sounds)
├── Services/             # Business logic (WuphfService)
├── Platforms/            # Platform-specific code
├── MauiProgram.cs        # App configuration
└── App.xaml             # App shell
```

## 🏃‍♂️ Running the App

### Windows (Easiest)
```bash
dotnet run --framework net9.0-windows10.0.19041.0
```

### Android (Requires Android SDK)
```bash
dotnet run --framework net9.0-android
```

### iOS (Requires macOS and Xcode)
```bash
dotnet run --framework net9.0-ios
```

### macOS (Requires macOS and Xcode)
```bash
dotnet run --framework net9.0-maccatalyst
```

## 🧪 Testing

### Running Tests
```bash
dotnet test
```

### Manual Testing Checklist
- [ ] Dashboard loads with statistics
- [ ] Demo mode plays WOOF sounds
- [ ] Compose page allows message creation
- [ ] Contacts page shows all Dunder Mifflin employees
- [ ] Messages page displays sent/received/drafts
- [ ] Statistics page shows comprehensive metrics
- [ ] About page displays WUPHF information

## 📦 Dependencies

### Core Packages
- **Microsoft.Maui.Controls** - MAUI framework
- **Microsoft.AspNetCore.Components.WebView.Maui** - Blazor hybrid support
- **Plugin.Maui.Audio** - Audio playback for WOOF sounds
- **CommunityToolkit.Maui** - Additional MAUI controls

### Development Dependencies
- **Microsoft.Extensions.Logging.Debug** - Debug logging

## 🎯 Platform Support

| Platform | Status | Requirements |
|----------|--------|--------------|
| Windows | ✅ Fully Supported | Windows 10/11 |
| Android | 🔄 Supported* | Android SDK, API 24+ |
| iOS | 🔄 Supported* | macOS, Xcode 15+ |
| macOS | 🔄 Supported* | macOS, Xcode 15+ |

*Requires platform-specific development tools

## 🐛 Common Issues

### Build Errors

**"Android SDK directory could not be found"**
- Install Android SDK through Visual Studio or Android Studio
- Set `ANDROID_HOME` environment variable

**"Contact class ambiguous reference"**
- This was resolved by renaming our Contact class to WuphfContact
- Rebuild the solution if you encounter this

**"Keyframes does not exist in current context"**
- CSS @keyframes in Razor pages should be escaped as @@keyframes
- This is already fixed in the current codebase

### Runtime Issues

**Audio not playing in Demo mode**
- Ensure audio files are in Resources/Raw folder
- Check platform permissions for audio playback

## 🎨 Code Style

### C# Conventions
- Use PascalCase for public members
- Use camelCase for private fields
- Add XML documentation for public APIs
- Follow .NET naming conventions

### Blazor/Razor Conventions
- Use semantic HTML elements
- Keep component logic in code-behind when possible
- Use CSS classes for styling, avoid inline styles

### Office Theme Guidelines
- Reference actual characters and departments from The Office
- Keep humor appropriate and show-accurate
- Use consistent naming (e.g., "Dunder Mifflin" not "Dunder-Mifflin")

## 📝 Contributing Guidelines

1. **Fork the repository**
2. **Create a feature branch**: `git checkout -b feature/amazing-wuphf-feature`
3. **Make your changes** following the code style guidelines
4. **Test thoroughly** on your target platform(s)
5. **Commit with descriptive messages**: `git commit -m "Add WOOF sound variations for different message types"`
6. **Push to your fork**: `git push origin feature/amazing-wuphf-feature`
7. **Create a Pull Request** with a clear description

### Pull Request Template
- Describe what your PR does
- List any breaking changes
- Include screenshots for UI changes
- Test on at least one platform
- Reference any related issues

## 🎭 The Office References

When adding new features or content, please maintain the show's authenticity:

### Character Accuracy
- Michael Scott: Regional Manager, overly enthusiastic
- Dwight Schrute: Assistant (to the) Regional Manager, beet farmer
- Jim Halpert: Salesman, prankster
- Ryan Howard: WUPHF founder, temp-turned-entrepreneur

### Department Structure
- Management: Michael Scott
- Sales: Jim, Dwight, Phyllis, Andy, Stanley
- Accounting: Kevin, Oscar, Angela
- Reception: Pam
- HR: Toby
- Customer Service: Kelly
- Quality Assurance: Creed
- Supplier Relations: Meredith

## 📞 Support

- **Issues**: Use GitHub Issues for bug reports and feature requests
- **Discussions**: Use GitHub Discussions for general questions
- **Email**: [Your contact email if applicable]

## 🙏 Acknowledgments

- **Ryan Howard** - Original WUPHF concept (The Office, Season 7)
- **Dunder Mifflin Paper Company** - Fictional sponsor
- **The Office** - Inspiration and character references

---

*"WUPHF - Washington University Public Health Fund... connecting people!"* - Ryan Howard
