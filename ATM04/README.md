
# ATM04: Fully Implemented ATM Operations with Moq Testing

## Project Overview
This project builds upon ATM03 by introducing Moq testing for mocking certain dependencies. It includes the feature files, step definitions, fully implemented ATM operations, and Moq-based unit tests.

## Features
- Cucumber feature file for ATM operations
- Step definitions provided
- Fully implemented ATM operations
- Unit tests with Moq for mocking

## Prerequisites
- .NET 7 SDK (or higher)
- SpecFlow for Cucumber testing in C#
- Moq for unit testing

## Getting Started
1. Clone the repository.
2. Open the project in Visual Studio or any C# IDE.
3. Check the `SRC\Main\ATM.cs` file for the ATM logic.
4. Check the `SRC\Main\IAccountService.cs` file for the Moq integration logic from third party.
5. Review the Moq tests under `StepDefinitions/ATMOperationsSteps.cs`.

## Installing Dependencies
1. Install Moq using NuGet:
   ```bash
   dotnet add package Moq

## Running Tests
1. Navigate to the test project folder.
2. Use the following command to run tests:
   ```bash
   dotnet test
