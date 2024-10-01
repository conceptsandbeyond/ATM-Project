Feature: ATM Operations

  Scenario: Withdraw cash successfully
    Given the account balance is $1000
    When the user requests to withdraw $200
    Then the ATM should dispense $200
    And the account balance should be $800

  Scenario: Withdraw cash with insufficient funds
    Given the account balance is $100
    When the user requests to withdraw $200
    Then the ATM should display an insufficient funds message
    And the account balance should remain $100
