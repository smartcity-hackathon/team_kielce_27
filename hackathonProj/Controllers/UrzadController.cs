using System.Linq;
using hackathonProj.Extensions;
using hackathonProj.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace hackathonProj.Controllers
{
    public class UrzadController : Controller
    {
        [Route("Urzad")]
        [Route("Urzad/[controller]")]

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
          var ts = new UrzadService();
          return id.IsNull() ? Json(ts.GetUrzadList(urzadSc: new Model.SearchCriterias.UrzadSC() { Id = id }).FirstOrDefault()) : Json(ts.GetUrzadList());
        }

        [HttpGet]
        public IActionResult Get()
        {
            var ts = new UrzadService();
            var temp2 = ts.GetUrzadList();
            return Json(temp2);
        }

    }
}