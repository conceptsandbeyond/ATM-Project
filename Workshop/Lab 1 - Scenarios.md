Lab 1 - Behaviour Scenario

<p> 

## <b>**Write Scenario for Feature ATM Operations**</b>

1. Make sure you are in your branch - feature/Student\<team number\>

2. Bring in folder from base branch for the lab

```
git checkout base -- ATM00
```

3. Open file - ATM00\Tests\Features\ATMOperations.feature

This file contains the scenarios that you need to add for behaviour testing. 

Write the following two scenarios and commit your changes


1. Scenario 1 -  Withdraw cash successfully

assuming the account balance of $1000, if user requests to withdraw $200, ATM will dispence $200 and remaining balance changes to $800

2. Scenario 2 - Withdraw cash when balance is insufficient 
assuming the account balance of $100, if user requests to withdraw $200, ATM will display insufficient funds message and remaining balance remains to $100


No need to run tests yet, just commit your changes

```
git add .
git commit -m "adding scenarios"
```


## Example Feature

```
Feature: ATM Operations
  Scenario: Successful Withdrawal
    Given the account balance is 100
    When the user withdraws 50
    Then the account balance should be 50
```