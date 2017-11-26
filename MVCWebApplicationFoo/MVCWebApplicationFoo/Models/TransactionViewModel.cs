using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplicationFoo.Models
{
    public class TransactionViewModel
    {
        public decimal Deposit { get; set; }
        public string UserId { get; set; }
    }
}