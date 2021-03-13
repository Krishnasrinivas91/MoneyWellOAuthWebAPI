using OAuthTokenWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OAuthTokenWebAPI.DB
{
    public class BankingContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public BankingContext() : base("BankingContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                        .HasRequired(e => e.BankAccount)
                        .WithRequiredPrincipal();

            modelBuilder.Entity<BankAccount>()
                        .HasRequired(e => e.Customer)
                        .WithRequiredPrincipal();

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<BankAccount>().ToTable("BankAccount");
        }
    }
}