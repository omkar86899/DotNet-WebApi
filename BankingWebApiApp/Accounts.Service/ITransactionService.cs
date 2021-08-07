using Accounts.Model;
using System;
using System.Collections.Generic;

namespace Accounts.Service
{
    public interface ITransactionService
    {
        void AddTransaction(Transaction transaction, String userName);
        List<Transaction> GetTransactions(string userName);
    }
}