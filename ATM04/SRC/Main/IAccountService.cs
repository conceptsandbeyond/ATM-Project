namespace ATM04.SRC.ATM
{
    public interface IAccountService
    {
        decimal GetBalance(string accountId);
        void UpdateBalance(string accountId, decimal newBalance);
    }
}
