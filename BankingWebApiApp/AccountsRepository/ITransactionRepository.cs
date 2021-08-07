using Accounts.Model;
using System;
using System.Collections.Generic;

namespace AccountsRepository
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction, String userName);

        List<Transaction> GetTransactions(String userName);
    }
}