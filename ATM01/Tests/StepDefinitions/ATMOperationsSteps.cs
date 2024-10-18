
namespace ATM01.Tests.StepDefinitions
{
    [Binding]
    public class ATMOperationsSteps
    {
        [Given(@"the account balance is \$(.*)")]
        public void GivenTheAccountBalanceIs(decimal balance)
        {
            // TODO: Implement GivenTheAccountBalanceIs$
            throw new PendingStepException();
        }

        [When(@"the user requests to withdraw \$(.*)")]
        public void WhenTheUserRequestsToWithdraw(decimal amount)
        {
            // TODO: Implement WhenTheUserRequestsToWithdraw$
            throw new PendingStepException();
        }

        [Then(@"the ATM should dispense \$(.*)")]
        public void ThenTheATMShouldDispense(decimal amount)
        {
            // TODO: Implement ThenTheATMShouldDispense$
            throw new PendingStepException();
        }

        [Then(@"the account balance should be \$(.*)")]
        public void ThenTheAccountBalanceShouldBe(decimal balance)
        {
            // TODO: Implement ThenTheAccountBalanceShouldBe$
            throw new PendingStepException();
        }

        [Then(@"the ATM should display an insufficient funds message")]
        public void ThenTheATMShouldDisplayAnInsufficientFundsMessage()
        {
            // TODO: Implement ThenTheATMShouldDisplayAnInsufficientFundsMessage
            throw new PendingStepException();
        }

        [Then(@"the account balance should remain \$(.*)")]
        public void ThenTheAccountBalanceShouldRemain(decimal balance)
        {
            // TODO: Implement ThenTheAccountBalanceShouldBe$
            throw new PendingStepException();
        }
    }
}
