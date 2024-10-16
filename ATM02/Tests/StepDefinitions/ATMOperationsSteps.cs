using NUnit.Framework;

namespace ATM02.Tests.StepDefinitions
{
    [Binding]
    public class ATMOperationsSteps
    {
        private decimal _accountBalance;
        private decimal _withdrawAmount;
        private decimal _dispensedAmount;
        private string _message;

        [Given(@"the account balance is \$(.*)")]
        public void GivenTheAccountBalanceIs(decimal balance)
        {
            _accountBalance = balance;
        }

        [When(@"the user requests to withdraw \$(.*)")]
        public void WhenTheUserRequestsToWithdraw(decimal amount)
        {
            _withdrawAmount = amount;
            //TODO: Since main code is not implemented, simulate the withdraw behavior

        }

        [Then(@"the ATM should dispense \$(.*)")]
        public void ThenTheATMShouldDispense(decimal amount)
        {
            //TODO: Write the assert statement
        }

        [Then(@"the account balance should be \$(.*)")]
        public void ThenTheAccountBalanceShouldBe(decimal balance)
        {
            //TODO: Write the assert statement
        }

        [Then(@"the ATM should display an insufficient funds message")]
        public void ThenTheATMShouldDisplayAnInsufficientFundsMessage()
        {
            //TODO: Write the assert statement
        }

        [Then(@"the account balance should remain \$(.*)")]
        public void ThenTheAccountBalanceShouldRemain(decimal balance)
        {
            //TODO: Write the assert statement
        }
    }
}
