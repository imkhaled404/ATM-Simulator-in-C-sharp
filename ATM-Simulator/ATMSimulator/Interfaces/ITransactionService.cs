using ATMSimulator.Entities;

namespace ATMSimulator.Interfaces
{
    public interface ITransactionService
    {
        Account WithdrawFunds(Account transactionAccount, decimal amount);

        Account DepositFunds(Account transactionAccount, decimal amount);

        decimal CheckBalance(string fromAccount);

        bool CheckIfValidTransaction(Account validateAccount, decimal amount, int action);

        decimal ReadAndValidateInputAmount();
    }
}
