using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OAuthTokenWebAPI.Models
{
    [Table("Customer")]
    public class BankAccount
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal AccountBalance { get; set; }
        public virtual Customer Customer { get; set; }
    }
}