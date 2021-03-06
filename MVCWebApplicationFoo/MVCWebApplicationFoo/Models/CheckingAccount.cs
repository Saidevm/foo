﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebApplicationFoo.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Its important")]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Only numberic in 6-10")]
        [Display(Name ="Account#")]
        public int AccountNumber { get; set; }

        [Display(Name ="First Name")]
        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }
}