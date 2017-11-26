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
        

        // GET: Transaction/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(TransactionViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CheckingAccount acc;
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        string i = User.Identity.GetUserId();
                        acc = db.CheckingAccounts.Where(s => s.ApplicationUserId == i).FirstOrDefault();

                        var tr = new Transaction { CheckingAccountId = acc.Id, Deposit = model.Deposit };
                        db.Transactions.Add(tr);
                        db.SaveChanges();
                    }
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
