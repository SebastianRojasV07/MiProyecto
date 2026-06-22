# Calculator App

## Description
A clean and structured calculator application developed in C#, focusing on Clean Code principles and SOLID architecture.

## Features
- Addition
- Subtraction
- Multiplication
- Division

## Architecture & Refactoring (Clean Code)
This project was refactored from a single-block script into a decoupled, professional architecture by solving four major code smells and architectural violations:

### 1. Violation #1: Bad Naming Conventions
- **The Problem:** Used generic and confusing variable names (`a`, `b`, `c`, `d`, `n`).
- **The Refactoring:** Renamed them to self-explanatory variables (`firstNumber`, `secondNumber`, `result`, `option`) to make the code readable without comments.

### 2. Violation #2: Single Responsibility Principle (SRP) Broken
- **The Problem:** The main block was handling user interface (UI), flow control, and mathematical calculations all at the same time.
- **The Refactoring:** Decoupled the responsibilities into independent classes:
  - `PantallaConsola`: Exclusively manages user input and output.
  - `CalculadoraMatematica`: Exclusively handles pure mathematical operations.

### 3. Violation #3: Code Duplication (DRY Principle)
- **The Problem:** User prompts and input conversions (`Convert.ToInt32(Console.ReadLine())`) were repeated four times inside the `switch` blocks.
- **The Refactoring:** Created a reusable method `PedirEntrada()` inside the UI class to handle input globally, eliminating all duplicate code.

### 4. Violation #4: Open/Closed Principle (OCP) Broken
- **The Problem:** Adding a new mathematical operation forced modifications inside the `CalculadoraMatematica` class and required adding a new case to the `switch` statement in the main application loop.
- **The Refactoring:** Introduced the `IOperacion` interface to isolate each mathematical operation into its own separate class. Replaced the rigid `switch` statement with a `Dictionary<int, IOperacion>` collection. The system is now open for extension (adding new operations as distinct classes) but closed for modification.

## Technologies
- C#
- .NET

## How to Run
1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Run `Program.cs`

## Author
**Sebastian Rojas Valencia**
