using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OAuthTokenWebAPI.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}