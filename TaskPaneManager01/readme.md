# TaskPaneManager01

A modular VSTO add-in for Microsoft PowerPoint (.NET Framework 4.7.2, C# 7.3) that provides a flexible, extensible system for managing multiple custom task panes (Main, Settings, Help) with context-aware controls.

## Features

- **Multiple Task Panes:** Easily toggle, show, or hide Main, Settings, and Help panes from the Ribbon.
- **Context Injection:** Each pane receives a shared PowerPoint context for accessing the active presentation, window, and selection.
- **Factory Pattern:** Task panes are created and configured via a factory, supporting custom titles, docking, and sizing.
- **Event Handling:** Panes are notified when their visibility changes and can react to PowerPoint selection/window events.

## Project Structure

- `TaskPaneManager01\TaskPaneManager01\TaskPane\`
  - `TaskPaneManager.cs` – Manages pane lifecycle and visibility.
  - `DefaultTaskPaneFactory.cs` – Creates and configures pane controls.
  - `IPowerPointContext.cs` / `PowerPointContext.cs` – Exposes PowerPoint state and events.
  - `ITaskPaneFactory.cs`, `IPowerPointHost.cs`, `ITaskPaneAware.cs` – Interfaces for extensibility.
  - `PaneType.cs` – Enum for pane identification.
- `TaskPaneManager01\TaskPaneManager01\UserControls\`
  - `BaseTaskPaneControl.cs` – Base class for all pane controls.
  - `MainTaskPaneControl.cs`, `SettingsTaskPaneControl.cs`, `HelpTaskPaneControl.cs` – Implementations for each pane.
- `Ribbon1.cs` – Ribbon integration for pane toggling.
- `ThisAddIn.cs` – Add-in startup, context, and manager initialization.

## Requirements

- Visual Studio 2022
- .NET Framework 4.7.2
- Microsoft Office PowerPoint (VSTO support enabled)

## Getting Started

1. **Clone the repository** and open the solution in Visual Studio 2022.
2. **Restore NuGet packages** (if any) and ensure references to `Microsoft.Office.Interop.PowerPoint` and `Microsoft.Office.Tools.Common` are valid.
3. **Build the solution.**
4. **Run/Debug**: Start PowerPoint with the add-in loaded (F5 in Visual Studio).
5. **Use the Ribbon**: The add-in adds a custom Ribbon with buttons to toggle the Main, Settings, and Help task panes.

## Customization

- **Add new panes:**  
  1. Extend `PaneType` enum.  
  2. Create a new UserControl.  
  3. Update `DefaultTaskPaneFactory` to handle the new type.

- **Respond to context changes:**  
  Implement `OnToggle` and use the injected `IPowerPointContext` in your pane controls.

## License

MIT License

---

*This project is for demonstration and educational purposes. Not affiliated with or endorsed by Microsoft.*