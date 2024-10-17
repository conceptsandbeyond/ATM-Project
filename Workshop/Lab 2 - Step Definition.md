
Lab 2 - Step Definitions

<p> 

## <b>**Writing step definitions for your scenarios**</b>


**Working Directory - ATM01**

This project builds upon ATM00 by providing the feature file and step definitions, but without implementing the actual ATM code logic. This demonstrates writing tests first without writing the actual application logic.

1. Navigate to folder ATM01


2. Open and review file - ATM01\Tests\Features\ATMOperations.feature

This file should have the scenarios predefined 

3.  Navigate to the ATM01 folder and run the following commands to create the code for feature file.

```
cd ATM01
dotnet build
```


5. Open and review the file ATM01\Tests\StepDefinitions\ATMOperationsSteps.cs

This file should have step definitions skeleton with functions to bound with feature files. You would be using these functions to write your application test logic.



Navigate to the ATM01 folder and run the tests now. Run the following commands.

```
cd ATM01
dotnet test
```


## Simulating the tests within step definitions


**Working Directory - ATM02**

1. Navigate to Folder ATM02


2. Open and review the file ATM02\Tests\StepDefinitions\ATMOperationsSteps.cs

This is the continuation of the file that you reviewed in the previous step. 


As of now there is no function written to test yet. So in this file you will simulate the funciton behaviour.

Your task is to review the file and add function logic and missing assert statements.
(Complete the //TODO:)


Once completed, you should be able to test the functions.



Navigate to the ATM02 folder and run the tests now. Run the following commands.

```
cd ATM02
dotnet test
```

