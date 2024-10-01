# ATM01: Feature and Step Definitions Without Main Code

## Project Overview
This project builds upon ATM00 by providing the feature file and step definitions, but without implementing the actual ATM code logic. This demonstrates writing tests first without writing the actual application logic.

## Features
- Cucumber feature file for ATM operations
- Step definitions provided, but ATM operations are not yet implemented

## Prerequisites
- .NET 7 SDK (or higher)
- SpecFlow for Cucumber testing in C#

## Getting Started
1. Clone the repository.
2. Open the project in Visual Studio or any C# IDE.
3. Check the `Features/ATMOperations.feature` file for defined scenarios.
4. Review the step definitions under `StepDefinitions/ATMOperationsSteps.cs`.
5. Running the tests will result in failures with pending status, as the actual ATM operations are not implemented.

## Running Tests
1. Navigate to the test project folder.
2. Use the following command to run tests:
   ```bash
   dotnet test
