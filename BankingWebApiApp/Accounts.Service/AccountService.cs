using Accounts.Model;
using AccountsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public Account GetAccount(String userName)
        {
            return _accountRepository.GetAccount(userName);
        }

        public void AddAccount(Account account)
        {
            _accountRepository.AddAccount(account);
        }

        public void UpdateAccount(Account account)
        {
            _accountRepository.UpdateAccount(account);
        }
    }
}