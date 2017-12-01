using Microsoft.AspNet.Identity;
using MVCWebApplicationFoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationFoo.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        IApplicationDbContext db;

        public TransactionController()
        {
            db = new ApplicationDbContext();
        }

        public TransactionController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {            
            return View("Create");
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(Transaction model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //CheckingAccount acc;
                    //using (ApplicationDbContext db = new ApplicationDbContext())
                    //{
                        //string i = User.Identity.GetUserId();
                        //acc = db.CheckingAccounts.Where(s => s.ApplicationUserId == i).FirstOrDefault();

                        // var tr = new Transaction { CheckingAccountId = acc.Id, Deposit = model.Deposit };
                        db.Transactions.Add(model);
                        db.SaveChanges();
                    //}
                }
                return RedirectToAction("Create");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }
    }
}
