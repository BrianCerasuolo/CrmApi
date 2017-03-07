using Crm.Core.Interface;
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
        private readonly IRepository _accountService;
        public AccountController(IRepository repo)
        {
            _accountService = repo;
        }

        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("666");
        }
    }

    
}
