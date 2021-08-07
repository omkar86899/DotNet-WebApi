using Accounts.Model;

namespace Accounts.Service
{
    public interface IAccountService
    {
        void AddAccount(Account account);
        Account GetAccount(string userName);
        void UpdateAccount(Account account);
    }
}