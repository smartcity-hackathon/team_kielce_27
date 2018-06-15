using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackathonProj.Model.Services;
using System.IO;

namespace hackathonProj.Controllers
{
    [Route("Users")]
    [Route("Users/[controller]")]
    public class UserController : Controller
    {
        public string response() {
            return "ok";
        }
        [Route("Users/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create([FromBody]Model.Entities.Account account)
        {
            AccountService accounts = new AccountService();
            try
            {
                accounts.AddAccount(account);
                return new OkResult();
            }
            catch { return new BadRequestResult(); }
           

            //accounts.AddAccount(new Model.Entities.Account { })


// return View();
        }

    }
}