using ATM04.SRC.ATM;
using NUnit.Framework;

namespace ATM03.Tests.StepDefinitions
{
    [Binding]
    public class ATMOperationsSteps
    {
        private ATM _atm;
        private decimal _withdrawAmount;

        [Given(@"the account balance is \$(.*)")]
        public void GivenTheAccountBalanceIs(decimal balance)
        {
            _atm = new ATM(balance);
        }

        [When(@"the user requests to withdraw \$(.*)")]
        public void WhenTheUserRequestsToWithdraw(decimal amount)
        {
            _withdrawAmount = amount;
            _atm.Withdraw(_withdrawAmount);
        }

        [Then(@"the ATM should dispense \$(.*)")]
        public void ThenTheATMShouldDispense(decimal amount)
        {
            Assert.AreEqual(amount, _atm.DispensedAmount);
        }

        [Then(@"the account balance should be \$(.*)")]
        public void ThenTheAccountBalanceShouldBe(decimal balance)
        {
            Assert.AreEqual(balance, _atm.AccountBalance);
        }

        [Then(@"the ATM should display an insufficient funds message")]
        public void ThenTheATMShouldDisplayAnInsufficientFundsMessage()
        {
            Assert.AreEqual("Insufficient funds.", _atm.Message);
        }

        [Then(@"the account balance should remain \$(.*)")]
        public void ThenTheAccountBalanceShouldRemain(decimal balance)
        {
            Assert.AreEqual(balance, _atm.AccountBalance);
        }
    }
}
