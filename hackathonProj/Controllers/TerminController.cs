using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathonProj.Model.Entities;
using hackathonProj.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace hackathonProj.Controllers
{
  public class TerminController : Controller
  {
    [Route("Termin")]
    [Route("Termin/[controller]")]
    [HttpGet("{Id}")]
    public IActionResult GetbyId(int id)
    {
      var ts = new TerminService();
      return Json(ts.GetTerminList(terminSc: new Model.SearchCriterias.TerminSC() { Id = id }).FirstOrDefault());
    }

    [HttpGet]
    public IActionResult Get()
    {
      var ts = new TerminService();
      return Json(ts.GetTerminList());
    }
  }
}