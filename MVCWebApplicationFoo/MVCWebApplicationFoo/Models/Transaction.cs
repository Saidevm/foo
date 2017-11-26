using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApplicationFoo.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Deposit { get; set; }
        //public decimal Withdral { get; set; }
        public virtual CheckingAccount CheckingAccounts { get; set; }
        public int CheckingAccountId { get; set; }
    }
    
}