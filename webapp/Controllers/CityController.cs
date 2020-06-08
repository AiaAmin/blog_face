using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bll;
using Dal.models;
using Microsoft.AspNetCore.Razor.Language;
using Newtonsoft.Json;

namespace webapp.Controllers
{

    public class CityController : Controller
    {
        //call Data
        private ICityMgr cmgr;

        //for security
        public CityController()
        {
            cmgr = new CityMgr();
        }
        public IActionResult ViewCity()
        {
            List<City>cities  = cmgr.Find(new City());
            return View(cities);
           
        }
        public IActionResult SearchCity(string ip)
        {
            var city = cmgr.Find(new City());
            city.Where(p => p.Name.StartsWith(ip));
            return View(city);

        }
        public JsonResult listByJson()
        {
            List<City> cities = new List<City>() {
                new City() {Name="gharda2a",CreationDate=DateTime.Now },
                new City(){Name="Luxor",CreationDate=DateTime.Now}
               };
            return Json(cities);
        }
        // GET: Skills/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<City> cities = cmgr.Find(new City());
            if (cities[0] == null)
            {
                return NotFound();
            }

            return View(cities[0]);
        }

    }
}