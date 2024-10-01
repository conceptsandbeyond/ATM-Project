namespace ATM03.SRC.ATM
{
    public class ATM
    {
        public decimal AccountBalance { get; private set; }
        public decimal DispensedAmount { get; private set; }
        public string Message { get; private set; }

        public ATM(decimal initialBalance)
        {
            AccountBalance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= AccountBalance)
            {
                DispensedAmount = amount;
                AccountBalance -= amount;
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
