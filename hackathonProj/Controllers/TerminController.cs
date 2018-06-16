using System.Linq;
using hackathonProj.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace hackathonProj.Controllers
{
  [Route("api/Termin")]
  public class TerminController : Controller
  {
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

    [Route("SetTime")]
    [HttpGet("{wydzialId}")]
    public IActionResult Get(int wydzialId)
    {
      var gs = new GodzinaService();
      var times = gs.ParseTimes().Where(x => x.wydzialId == wydzialId).ToList();
      ViewBag.Times = times;
      return View("Date");
    }
  }
}