using Accounts.Model;
using System;
using System.Collections.Generic;

namespace AccountsRepository
{
    public interface IAccountRepository
    {
        void AddAccount(Account account);
        Account GetAccount(String userName);
        void UpdateAccount(Account account);
    }
}