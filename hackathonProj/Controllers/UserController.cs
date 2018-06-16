using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hackathonProj.Model.Services;
using hackathonProj.Extensions;

namespace hackathonProj.Controllers
{
  [Route("Users")]
  [Route("Users/[controller]")]
  public class UserController : Controller
  {
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