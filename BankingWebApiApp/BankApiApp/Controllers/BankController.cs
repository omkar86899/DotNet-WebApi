using Accounts.Model;
using Accounts.Service;
using BankApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BankApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/accounts")]
    public class BankController : ApiController
    {
        private IAccountService _accountService;
        private ITransactionService _transactionService;

        public BankController(IAccountService accountService, ITransactionService transactionService)
        {
            _accountService = accountService;
            _transactionService = transactionService;
        }

        [Route("{userName}")]
        public IHttpActionResult GetAccount(String userName)
        {
            Account account;

            try
            {
                account = _accountService.GetAccount(userName);
            } catch (Exception exception)
            {
                return BadRequest("Account not Found");
            }

            return Json(account);
        }

        [Route("")]
        public IHttpActionResult PostAccount(AccountModel accountModel)
        {
            Account account;

            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data not valid");
            }

            try
            {
                if (_accountService.GetAccount(accountModel.Name) != null)
                {
                    return BadRequest("Username Already Exist");
                }
            } catch (Exception exception)
            {

            }

            account = new Account
            {
                AccountId = Guid.NewGuid(),
                Name = accountModel.Name,
                Email = accountModel.Email,
                Balance = accountModel.Balance,
                Password = accountModel.Password
            };

            try
            {
                _accountService.AddAccount(account);
            }
            catch (Exception exception)
            {
                return InternalServerError(exception);
            }
            return Ok("Account Created");
        }

        [Route("{userName}/transactions")]
        public IHttpActionResult GetTransactions(String userName)
        {
            List<Transaction> transactions;

            try
            {
                transactions = _transactionService.GetTransactions(userName);
            } catch (Exception exception)
            {
                return BadRequest("Account Not Found");
            }

            return Ok(transactions);
        }

        [Route("{userName}/transactions")]
        public IHttpActionResult PostTransaction(String userName,TransactionModel transactionModel)
        {
            Transaction transaction;

            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data is Invalid");
            }

            transaction = new Transaction
            {
                TransactionId = Guid.NewGuid(),
                Amount = transactionModel.Amount,
                Time = DateTime.Now,
                Type = (TransactionType)Enum.Parse(typeof(TransactionType), transactionModel.TransactionType.ToString()),
            };

            try
            {
                _transactionService.AddTransaction(transaction, userName);
            }catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }

            return Ok("Transaction Successful");
        }
    }
}