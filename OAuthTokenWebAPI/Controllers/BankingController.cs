using OAuthTokenWebAPI.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OAuthTokenWebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Banking")]
    public class BankingController : ApiController
    {
        private BankingRepository _bankingRepository { get; set; }
        public BankingController()
        {
            _bankingRepository = new BankingRepository();
        }
        //[Authorize]
        [Route("GetCustomers")]
        public IHttpActionResult GetCustomers()
        {
            var customerData = _bankingRepository.GetCustomers();
            return Ok(customerData);
        }

        [Route("GetBankingAccounts")]
        public IHttpActionResult GetBankingAccounts()
        {
            var customerData = _bankingRepository.GetBankAccounts();
            return Ok(customerData);
        }
    }

    
}
