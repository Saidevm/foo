using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplicationFoo.Models
{
    public class CheckingAccount
    {
        [Required(ErrorMessage ="Its important")]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Only numberic in 6-10")]
        [Display(Name ="Account#")]
        public int AccountNumber { get; set; }

        [Display(Name ="First Name")]
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}