# CommonUtilities

A general-purpose .NET Framework 4.7.2 library of reusable helper classes, extension methods, and utility functions.

---

## Table of Contents

* [Getting Started](#getting-started)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Namespaces & Classes](#namespaces--classes)
* [Contributing](#contributing)
* [License](#license)

---

## Getting Started

Reference the `CommonUtilities` project or include its source files in your solution to access a suite of helper types that simplify data binding, logging, JSON handling, image processing, and more.

---

## Requirements

* .NET Framework 4.7.2
* Visual Studio 2017 or later

---

## Installation

1. Clone or download the TaskPaneManager01 repository.
2. In your solution, **Add → Existing Project…** and select `CommonUtilities\CommonUtilities.csproj`.
3. Add a project reference from your main project to `CommonUtilities`.

---

## Usage

Use the helper classes by adding the appropriate `using` directive:

```csharp
using CommonUtilities.Collections;
using CommonUtilities.Extensions;
using CommonUtilities.Helpers;
using CommonUtilities.Utility;
```

Examples:

* **Data binding & filtering** with `RbBindingList<T>`:

  ```csharp
  var list = new List<MyItem> { /* ... */ };
  var source = new RbBindingList<MyItem>(list);
  dataGridView.DataSource = source;
  source.ApplyFilter(item => item.IsActive);
  source.ResetFilter();
  ```

* **Logging** with `Logger`:

  ```csharp
  var log = new Logger(typeof(MyClass));
  log.Debug("Starting operation");
  ```

* **JSON file operations**:

  ```csharp
  var obj = JsonFileHelper.ReadFromFile<MySettings>("settings.json");
  JsonFileHelper.WriteToFile("out.json", obj);
  ```

---

## Namespaces & Classes

### CommonUtilities

* **HasPattern**: Utility methods for pattern detection and matching.

### CommonUtilities.Collections

* **RbBindingList<T>**: A `BindingList<T>` with an internal master list, plus `ApplyFilter` and `ResetFilter` methods.

### CommonUtilities.Extensions

* **ComboBoxExtensions**: Extension methods for `ComboBox` controls.
* **ControlExtensions**: Extension methods for Windows Forms `Control` types.
* **EnumExtension**: Helpers for working with `Enum` values.
* **ExceptionExtensions**: Adds functionality to `Exception`, such as retrieving full inner-message chains.
* **HttpClientExtensions**: Simplifies common `HttpClient` operations like JSON GET/POST.
* **IntExtensions**: Extension methods for `int`, e.g., range checks.
* **ObjectExtension**: General-purpose `object` extension methods.
* **StringExtensions**: String manipulation helpers, such as trimming, splitting, and pattern checks.
* **TableLayoutExtension**: Helpers for dynamically managing `TableLayoutPanel` rows and columns.

### CommonUtilities.Helpers

* **Base64Helper**: Encode/decode data to/from Base64 strings.
* **ColorsHelper**: Color conversion and manipulation utilities.
* **DirectoryHelper**: Directory creation, deletion, and file enumeration methods.
* **DoubleComparer**: Safe comparison of `double` values with tolerance support.
* **HasPattern**: (Helpers) Additional pattern-checking methods beyond the root-level type.
* **ImageFileHelper**: Methods for reading and writing image files from disk.
* **ImageHelper**: Image processing utilities, such as resizing and format conversion.
* **JObjectHelper**: Simplifies manipulation of `Newtonsoft.Json.Linq.JObject`.
* **JsonFileHelper**: Read/write JSON files using `Newtonsoft.Json`.
* **JsonHelper**: General JSON serialization/deserialization.
* **SizeCalcHelper**: Calculate dimensions and scaling factors for UI layouts.
* **ThreadSafeWrapper**: Provides locking wrappers for thread-safe operations.

### CommonUtilities.Utility

* **ActionExecutor**: Executes `Action` delegates with centralized exception handling.
* **BooleanResult**: Represents an operation result with `Success`, optional `Data`, and `ErrorMessage`.
* **BooleanResultArgs**: Event arguments that wrap a `BooleanResult`.
* **FunctionExecutor**: Executes `Func<T>` delegates, returning a `BooleanResult<T>`.
* **Logger**: Simple logging class for debug, info, warning, and error messages.
* **TimeIt**: Measures and logs the execution time of code blocks.

---

## Contributing

1. Fork the repository and create a feature branch.
2. Make your changes and add appropriate tests.
3. Submit a pull request describing your updates.

---

## License

This project is licensed under the MIT License. See [LICENSE](../LICENSE) for details.
