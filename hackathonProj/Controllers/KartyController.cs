using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathonProj.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace hackathonProj.Controllers
{
    public class KartyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll() {
            var ks = new KartaService();
            return Json(ks.GetKartaList());
        }
        [HttpGet("{Id}")]
        public IActionResult GetWydzial(int id) {
            var ks = new KartaService();
            return Json(ks.GetWydzial(id));

        }
    }
}