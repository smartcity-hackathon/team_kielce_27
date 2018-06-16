using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathonProj.Model.Entities;
using hackathonProj.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace hackathonProj.Controllers
{
  [Produces("application/json")]
  [Route("api/Home")]
  public class HomeController : Controller
  {
    [Route("")]
    public IActionResult Index()
    {
      var ks = new KartaService();
      var lista = ks.GetKartaList().Select(x => x.Nazwa);
      return Ok(lista);
    }

    [Route("Comp")]
    public IActionResult Test()
    {
      return View("Page");
    }

    [Route("Date")]
    public IActionResult Date()
    {
      return View("Date");
    }

    [Route("Parse")]
    public IActionResult Parse()
    {
      GodzinaService gs = new GodzinaService();
      var a = gs.ParseTimes();
      return View("Date");
    }
  }
}