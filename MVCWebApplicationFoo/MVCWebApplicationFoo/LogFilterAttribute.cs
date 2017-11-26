using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCWebApplicationFoo
{
    public class LogFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            // TO Do Log
            base.OnActionExecuted(filterContext);
        }
    }
}