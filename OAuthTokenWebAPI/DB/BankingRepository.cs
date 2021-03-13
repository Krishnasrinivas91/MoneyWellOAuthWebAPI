using OAuthTokenWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuthTokenWebAPI.DB
{
    public class BankingRepository : IDisposable
    {
        private BankingContext _ctx;
        
        public BankingRepository()
        {
            _ctx = new BankingContext();
        }

        public List<Customer> GetCustomers()
        {
            return _ctx.Customer.ToList();
        }

        public List<BankAccount> GetBankAccounts()
        {
            return _ctx.BankAccount.ToList();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}