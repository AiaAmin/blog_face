using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll;
using Dal.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Newtonsoft.Json;
using X.PagedList;

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
            return View();
        }
        /*   public IActionResult Search(string City)
           {
               List<City>cities = cmgr.Find(new City());
               return View(cities.Where(p => p.Name.StartsWith(City)));
           }*/

        public JsonResult List(int pageNumber, int pageSize)
        {
            var cities = cmgr.Find(new City()).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return Json(cities);
        }

        [HttpPost]
        public JsonResult Create(ViewModels.CityVM city)
        {
            City newCity = new City();
            newCity.Name = city.Name;
            cmgr.Add(newCity);
            return Json(newCity);
        }

        //Edit
        [HttpPost]
        public JsonResult EditCity([Bind(include: "Id,Name")] City city)
        {
            cmgr.Edit(city);
            return Json(city);
        }

        [HttpGet]
        public JsonResult EditCity(int id)
        {
            Console.WriteLine(id);
            List<City> cities = cmgr.Find(new City());
            return Json(cities.First(p => p.Id == id));
        }

        /*

        [HttpPut]
        public JsonResult EditCityPut (ViewModels.CityVM city) {
            Console.WriteLine (city.Id);
            List<City> cities = cmgr.Find (new City ());
            City editedCity = cities.First (p => p.Id == city.Id);
            cmgr.Edit (editedCity);
            return Json (editedCity);
        }*/
        //Details
        [HttpGet]
        public JsonResult DetailsCity(int id)
        {
            Console.WriteLine(id);
            List<City> cities = cmgr.Find(new City());
            return Json(cities.First(p => p.Id == id));
        }

        //-------------------------------

        [HttpDelete]
        public JsonResult DeleteCity(int id)
        {
            Console.WriteLine(id);
            List<City> cities = cmgr.Find(new City());
            cmgr.Remove((cities.First(p => p.Id == id)).Id);
            return Json(cities);
        }

        public PartialViewResult SearchPartial(string City)
        {
            List<City> cities = cmgr.Find(new City());
            return PartialView("_citySearch", cities.Where(p => p.Name.StartsWith(City)));
        }

        // GET: City/Details
        public ActionResult Details(int id)
        {
            if (id - 1 == null)
            {
                return NotFound();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<City> cities = cmgr.Find(new City());
            if (cities.First(p => p.Id == id) == null)
            {
                return NotFound();
            }

            return View(cities.First(p => p.Id == id));
        }
        //Delete

        // GET: City/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<City> cities = cmgr.Find(new City());
            if (cities.First(p => p.Id == id) == null)
            {
                return NotFound();
            }

            return View(cities.First(p => p.Id == id));
        }

        //------------------------------------------
        // POST: city/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cmgr.Remove(id);
            return RedirectToAction("viewCity");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<City> cities = cmgr.Find(new City());
            if (cities[id] == null)
            {
                return NotFound();
            }

            return View(cities[id]);
        }

        // POST: Cities/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(include: "Id,Name,CreationDate,OwnerId,LastModificationDate,ModifierId")]
            City city)
        {
            if (ModelState.IsValid)
            {
                cmgr.Edit(city);
                return RedirectToAction("ViewCity");
            }

            return View(city);
        }
    }
}