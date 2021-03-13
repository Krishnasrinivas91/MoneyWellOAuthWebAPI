using Microsoft.AspNet.Identity.EntityFramework;
using OAuthTokenWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OAuthTokenWebAPI.DB
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {       
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}