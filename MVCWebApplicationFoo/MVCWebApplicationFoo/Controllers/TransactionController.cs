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

        public TransactionController()
        {
            db = new ApplicationDbContext();
        }

        IApplicationDbContext db;
        public TransactionController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: Transaction/Create
        public ActionResult Create(int CheckingAccountId)
        {
            return View();
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(Transaction model)
        {
            try
            {
                if (ModelState.IsValid)
                { 
                    db.Transactions.Add(model);
                    db.SaveChanges();
                }
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }
    }
}
