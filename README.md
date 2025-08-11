# Project Summary

**mslearn-copilot-csharp** is a C# solution containing a console application and a corresponding unit test project.

## Structure

- **[`ConsoleApp`](../ConsoleApp )**
	- Main C# console application.
	- Contains business logic, including the [`Number`](../ConsoleApp/Number.cs ) class.

- **[`ConsoleApp.Tests`](../ConsoleApp.Tests )**
	- xUnit-based unit test project.
	- Contains tests for the application logic, such as [`UnitTests`](../ConsoleApp.Tests/UnitTests.cs ).

- **[`mslearn-copilot-csharp.generated.sln`](../mslearn-copilot-csharp.generated.sln )**
	- Visual Studio solution file referencing both projects.

## Features

- Implements core logic in a console application.
- Provides automated tests using xUnit.
- Supports .NET 9.0 and .NET 8.0 target frameworks.
- Ready for development in Visual Studio Code with dev container support.

## How to Build and Test

```sh
dotnet build
dotnet test
```

## Key Files

- [`ConsoleApp/Program.cs`](../ConsoleApp/Program.cs ): Application entry point.
- [`ConsoleApp/Number.cs`](../ConsoleApp/Number.cs ): Number-related logic.
- [`ConsoleApp.Tests/UnitTests.cs`](../ConsoleApp.Tests/UnitTests.cs ): Unit tests for `Number` methods.

---

For more details, see the individual project files.
