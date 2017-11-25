using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplicationFoo.Controllers
{
    public class HomeController : Controller
    {
        [LogFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //return partial view
        public ActionResult Contact()
        {
            ViewBag.Message = "Contract.";
            
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = message;

            return View();
        }


        // return http status code result / content
        public ActionResult Serial(string lcase)
        {
            if(lcase == "upper")
            return Content("ATM1000");

            return new HttpStatusCodeResult(500);
        }

        //json result
        public ActionResult GetJson()
        {
            return Json(new { name= "Saidev" }, JsonRequestBehavior.AllowGet);
        }

        //redirect to routeresult
        public ActionResult GetRoute()
        {
            return RedirectToAction("Index");
        }

        [HandleError(ExceptionType =typeof(StackOverflowException),View ="StackError")]
        public ActionResult GetError()
        {
            throw new StackOverflowException();
        }
    }
}