# Calculator App

## Description
A clean and structured calculator application developed in C#, focusing on Clean Code principles and SOLID architecture.

## Features
- Addition
- Subtraction
- Multiplication
- Division

## Architecture & Refactoring (Clean Code)
This project was refactored from a single-block script into a decoupled, professional architecture by solving three major code smells:

### Violation #1: Bad Naming Conventions
- **The Problem:** Used generic and confusing variable names (`a`, `b`, `c`, `d`, `n`).
- **The Refactoring:** Renamed them to self-explanatory variables (`firstNumber`, `secondNumber`, `result`, `option`) to make the code readable without comments.

### Violation #2: Single Responsibility Principle (SRP) Broken
- **The Problem:** The main block was handling user interface (UI), flow control, and mathematical calculations all at the same time.
- **The Refactoring:** Decoupled the responsibilities into independent classes:
  - `PantallaConsola`: Exclusively manages user input and output.
  - `CalculadoraMatematica`: Exclusively handles pure mathematical operations.

### Violation #3: Code Duplication (DRY Principle)
- **The Problem:** User prompts and input conversions (`Convert.ToInt32(Console.ReadLine())`) were repeated four times inside the `switch` blocks.
- **The Refactoring:** Created a reusable method `PedirEntrada()` inside the UI class to handle input globally, eliminating all duplicate code.

## Technologies
- C#
- .NET

## How to Run
1. Clone the repository
2. Open the project in Visual Studio or VS Code
3. Run `Program.cs`

## Author
**Sebastian Rojas Valencia**
