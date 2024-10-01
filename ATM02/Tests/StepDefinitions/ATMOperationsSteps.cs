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
            // Since main code is not implemented, simulate behavior
            if (_withdrawAmount <= _accountBalance)
            {
                _dispensedAmount = _withdrawAmount;
                _accountBalance -= _withdrawAmount;
                _message = "Withdrawal successful.";
            }
            else
            {
                _dispensedAmount = 0;
                _message = "Insufficient funds.";
            }
        }

        [Then(@"the ATM should dispense \$(.*)")]
        public void ThenTheATMShouldDispense(decimal amount)
        {
            Assert.AreEqual(amount, _dispensedAmount);
        }

        [Then(@"the account balance should be \$(.*)")]
        public void ThenTheAccountBalanceShouldBe(decimal balance)
        {
            Assert.AreEqual(balance, _accountBalance);
        }

        [Then(@"the ATM should display an insufficient funds message")]
        public void ThenTheATMShouldDisplayAnInsufficientFundsMessage()
        {
            Assert.AreEqual("Insufficient funds.", _message);
        }

        [Then(@"the account balance should remain \$(.*)")]
        public void ThenTheAccountBalanceShouldRemain(decimal balance)
        {
            Assert.AreEqual(balance, _accountBalance);
        }
    }
}
