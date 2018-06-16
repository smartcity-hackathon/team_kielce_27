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
      //  public IActionResult Index()
      // {
      //      return View();
      //  }
        [HttpGet("{Id}")]
        public IActionResult GetbyId(int id) {
            TerminService ts = new TerminService();
            
            if (id != null)
                return Json(ts.GetTerminList(terminSc: new Model.SearchCriterias.TerminSC() { Id = id }).FirstOrDefault());
            else
                return Json(ts.GetTerminList());
            

        }
        [HttpGet]
        public IActionResult Get()
        {
            TerminService ts = new TerminService();
            var temp2 = ts.GetTerminList();
            return Json(temp2);

        }

    }
}