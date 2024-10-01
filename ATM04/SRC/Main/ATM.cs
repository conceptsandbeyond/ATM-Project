namespace ATM04.SRC.ATM
{
    public class ATM
    {
        private readonly IAccountService _accountService;
        private readonly string _accountId;

        public decimal DispensedAmount { get; private set; }
        public string Message { get; private set; }

        public ATM(IAccountService accountService, string accountId)
        {
            _accountService = accountService;
            _accountId = accountId;
        }

        public void Withdraw(decimal amount)
        {
            var balance = _accountService.GetBalance(_accountId);
            if (amount <= balance)
            {
                DispensedAmount = amount;
                balance -= amount;
                _accountService.UpdateBalance(_accountId, balance);
                Message = "Withdrawal successful.";
            }
            else
            {
                DispensedAmount = 0;
                Message = "Insufficient funds.";
            }
        }
    }
}
