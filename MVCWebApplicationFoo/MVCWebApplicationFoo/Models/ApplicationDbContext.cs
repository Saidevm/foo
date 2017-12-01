﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApplicationFoo.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<CheckingAccount> CheckingAccounts { get; set; }
        IDbSet<Transaction> Transactions { get; set; }
        int SaveChanges();
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }
        public IDbSet<Transaction> Transactions { get; set; }
    }

    public class FakeDbContext: IApplicationDbContext
    {
        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }
        public IDbSet<Transaction> Transactions { get; set; }
        public int SaveChanges()
        {
            return 0;
        }
    }
}