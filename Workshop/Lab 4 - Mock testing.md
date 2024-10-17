
Lab 4 - Adding mock functions

<p> 


## <b>**Writing function to pass the test cases**</b>

**Working Directory - ATM04**

This project builds upon ATM03 by introducing Moq testing for mocking certain dependencies. It includes the feature files, step definitions, fully implemented ATM operations, and Moq-based unit tests.


1. Open file - ATM04\SRC\Main\IAccountService.cs to review the moq integration logic, This file simulates accessing third party APIs. In this example its using two functions ***GetBalance*** and ***UpdateBalance***  


2. Open file - ATM04\SRC\ATM\ATM.cs. Notice how the new application logic is using the IAccountService calls.


3. Your task is to create a mock function to simulate the behaviour of the third party application. 


4. Review the previously created step definitions file and add mock functionality ***using Moq*** Use this file to add your steps - ATM04\Tests\StepDefinitions\ATMOperationsSteps.cs


Once the application logic is added you can run the tests.


Run the following command from your terminal to run the tests.

```
cd ATM04
dotnet test
```

