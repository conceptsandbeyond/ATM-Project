using ATM04.SRC.ATM;
using Moq;
using NUnit.Framework;

namespace ATM04.Tests.StepDefinitions
{
    [Binding]
    public class ATMOperationsSteps
    {
        private Mock<IAccountService> _accountServiceMock;
        private ATM _atm;
        private string _accountId = "12345";
        private decimal _initialBalance;
        private decimal _withdrawAmount;

        [Given(@"the account balance is \$(.*)")]
        public void GivenTheAccountBalanceIs(decimal balance)
        {
            _initialBalance = balance;
            _accountServiceMock = new Mock<IAccountService>();
            _accountServiceMock.Setup(s => s.GetBalance(_accountId)).Returns(_initialBalance);
            _atm = new ATM(_accountServiceMock.Object, _accountId);
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
            Assert.AreEqual(amount <= _initialBalance ? amount : 0, _atm.DispensedAmount);
        }

        [Then(@"the account balance should be \$(.*)")]
        public void ThenTheAccountBalanceShouldBe(decimal balance)
        {
            if (_withdrawAmount <= _initialBalance)
            {
                _accountServiceMock.Verify(s => s.UpdateBalance(_accountId, balance), Times.Once);
            }
            else
            {
                _accountServiceMock.Verify(s => s.UpdateBalance(It.IsAny<string>(), It.IsAny<decimal>()), Times.Never);
            }
        }

        [Then(@"the ATM should display an insufficient funds message")]
        public void ThenTheATMShouldDisplayAnInsufficientFundsMessage()
        {
            Assert.AreEqual("Insufficient funds.", _atm.Message);
        }

        [Then(@"the account balance should remain \$(.*)")]
        public void ThenTheAccountBalanceShouldRemain(decimal balance)
        {
            if (_withdrawAmount <= _initialBalance)
            {
                _accountServiceMock.Verify(s => s.UpdateBalance(_accountId, balance), Times.Once);
            }
            else
            {
                _accountServiceMock.Verify(s => s.UpdateBalance(It.IsAny<string>(), It.IsAny<decimal>()), Times.Never);
            }
        }
    }
}
