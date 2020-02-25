using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsCodingTest.Factories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BackendForAssessment.Controllers
{
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        [Route("api/accounts")]
        public string GetAllAccounts()
        {
            var accounts = AccountsMockDataFactory.CreateAccountsCollection();
            return JsonConvert.SerializeObject(accounts);
        }
    }
}