using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCWebApplicationFoo.Controllers;
using MVCWebApplicationFoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCWebApplicationFoo.Tests.Controllers
{
    [TestClass]
    public class TransactionUnitTest
    {
        [TestMethod]
        public void CheckDepositAmount()
        {
            FakeDbContext db = new FakeDbContext();
            db.Transactions = new FakeDbSet<Transaction>();
            TransactionController tc = new TransactionController(db);
            var tra = new Transaction { Amount = 10, CheckingAccountId = 1 };
            tc.Create(tra);
            Assert.AreEqual(11, db.Transactions.Where(c=>c.CheckingAccountId ==1).FirstOrDefault().Amount);
        }

        [TestMethod]
        public void CheckDepositControllerView()
        {
            TransactionController tc = new TransactionController();
            var re = tc.Create() as ViewResult;
            Assert.AreEqual(re.ViewName, "Create");
        }
    }
}
