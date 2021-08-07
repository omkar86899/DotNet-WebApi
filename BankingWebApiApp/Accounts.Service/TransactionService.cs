using Accounts.Model;
using AccountsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Service
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository _transactionRepository;

        public TransactionService()
        {
            _transactionRepository = new TransactionRepository();
        }

        public List<Transaction> GetTransactions(String userName)
        {
            return _transactionRepository.GetTransactions(userName);
        }

        public void AddTransaction(Transaction transaction, String userName)
        {
            _transactionRepository.AddTransaction(transaction, userName);
        }
    }
} 
