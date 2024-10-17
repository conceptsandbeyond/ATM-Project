
Lab 4 - Adding mock functions

<p> 


## <b>**Writing function to pass the test cases**</b>

This project builds upon ATM03 by introducing Moq testing for mocking certain dependencies. It includes the feature files, step definitions, fully implemented ATM operations, and Moq-based unit tests.


1. Open file - ATM04\SRC\Main\IAccountService.cs to review the moq integration logic, This file simulates accessing third party APIs. In this example its using two functions ***GetBalance*** and ***UpdateBalance***  


2. Open file - ATM04\SRC\ATM\ATM.cs. Notice how the new application logic is using the IAccountService calls.


3. You would need to create a mock function to simulate the behaviour of the third party application. Review the previously created step definitions file and add mock functionality ***using Moq***


4. Use this file to add steps - ATM04\Tests\StepDefinitions\ATMOperationsSteps.cs



Once the application logic is added you can run the tests.


Run the following commands to run the tests.

```
dotnet test
```

