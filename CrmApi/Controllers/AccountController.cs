using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrmApi.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Account.CreateAccounts());
        }
    }

    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string CustomerUniqueIdentifier { get; set; }

        public static List<Account> CreateAccounts()
        {
            List<Account> accountList = new List<Account>
            {
                new Account {Id = 10248, AccountName = "Taiseer Joudeh" },
                new Account {Id = 10249, AccountName = "Ahmad Hasan" },
                new Account {Id = 10250, AccountName = "Tamer Yaser"},
                new Account {Id = 10251, AccountName = "Lina Majed"},
                new Account {Id = 10252, AccountName = "Yasmeen Rami"}
            };

            return accountList;
        }
    }
}
