using Accounts.Model;
using Accounts.Service;
using BankApiApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics;
using System.Web.Http.Results;

namespace BankApiTest
{
    [TestClass]
    public class BankControllerTest
    {
        [TestMethod]
        public void WhenCallGetAccountWithValidDataAccountDetailsShouldBeReturned()
        {
            //Arrange
            var accountService = new Mock<IAccountService>();
            var transactionService = new Mock<ITransactionService>();
            BankController controller = new BankController(accountService.Object, transactionService.Object);

            //Act
            var response = controller.GetAccount("omkar");
            var contentResult = response as OkNegotiatedContentResult<Account>;

            //Assert
            Assert.AreEqual("omkar",contentResult);
        }
    }
}
