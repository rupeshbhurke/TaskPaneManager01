# TaskPaneManager01

A VSTO PowerPoint Add‑in solution and accompanying utilities to manage multiple custom task panes and streamline PowerPoint automation.

---

## Projects

* **CommonUtilities**
  Reusable helper library of extension methods, helpers, and utilities (data binding, JSON, image processing, logging, etc.).
  [View CommonUtilities/README.md](CommonUtilities/README.md)

* **TaskPaneManager01**
  The main VSTO Add‑in project containing:

  * A **TaskPaneManager** that lazily creates, shows, hides, and toggles multiple `CustomTaskPane`s
  * An **ITaskPaneFactory** for decoupled creation of UserControls per pane type
  * **IPowerPointContext** for centralized PowerPoint application and selection state
  * Ribbon callbacks, UserControls, and configuration logic

  [View TaskPaneManager01/README.md](TaskPaneManager01/README.md)

---

## Getting Started

### Prerequisites

* Visual Studio 2017 or later
* .NET Framework 4.7.2
* Office Developer Tools for VSTO

### Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/rupeshbhurke/TaskPaneManager01.git
   cd TaskPaneManager01
   ```
2. **Open the solution**
   Double‑click `TaskPaneManager01.sln` in Visual Studio.
3. **Build & Run**
   Press **F5** to launch PowerPoint with the add‑in loaded.

---

## Solution Structure

```
TaskPaneManager01/           # Root folder
├── CommonUtilities/         # Helper library (see CommonUtilities/README.md)
├── TaskPaneManager01/       # VSTO add-in project (see TaskPaneManager01/README.md)
├── TaskPaneManager01.sln    # Visual Studio solution
├── .editorconfig            # Coding style settings
└── .gitignore               # Files to ignore in Git
```

---

## Contributing

Contributions are welcome! To contribute:

1. Fork the repo
2. Create a feature branch (`git checkout -b feature/XYZ`)
3. Commit your changes and push (`git push origin feature/XYZ`)
4. Submit a Pull Request

Please follow existing code style and update documentation as needed.

---

## License

This project is released under the MIT License. See [LICENSE](LICENSE) for details.
