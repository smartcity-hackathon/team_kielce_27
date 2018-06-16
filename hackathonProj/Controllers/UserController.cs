using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackathonProj.Model.Services;
using System.IO;
using hackathonProj.Model.Entities;
using hackathonProj.Extensions;

namespace hackathonProj.Controllers
{
  [Route("Users")]
  [Route("Users/[controller]")]
  public class UserController : Controller
  {
    //    public string response() {
    //        return "ok";
    //    }

    [HttpPost("Create")]
    public IActionResult Create(Model.Entities.Account account)
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
    [HttpGet("{Get}")]
    public IActionResult Get(string name)
    {
      AccountService acc = new AccountService();
      var temp = acc.GetAccountList(accountSc: new Model.SearchCriterias.AccountSC() { Username = name }).FirstOrDefault();
      return Json(temp);

    }

    [HttpPost("{Login}")]
    public IActionResult Login(string username, string password)
    {
      AccountService acc = new AccountService();
      var temp = acc.GetAccountList(accountSc: new Model.SearchCriterias.AccountSC() { Username = username, Password = password }).FirstOrDefault();
      if (temp.IsNull())
      {
        ViewData["Message"] = "bledne dane";
        return View("Index");
      }
      return View("UserPanel");

    }
  }
}