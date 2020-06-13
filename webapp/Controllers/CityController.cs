using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll;
using Dal.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Newtonsoft.Json;

namespace webapp.Controllers {

    public class CityController : Controller {
        //call Data
        private ICityMgr cmgr;

        //for security
        public CityController () {
            cmgr = new CityMgr ();
        }
        public IActionResult ViewCity () {
            List<City> cities = cmgr.Find (new City ());
            return View (cities);

        }
        /*   public IActionResult Search(string City)
           {
               List<City>cities = cmgr.Find(new City());
               return View(cities.Where(p => p.Name.StartsWith(City)));
           }*/

        public PartialViewResult CreatePartial () {
            return PartialView ("_cityCreate");
        }
        public PartialViewResult SearchPartial (string City) {
            List<City> cities = cmgr.Find (new City ());
            return PartialView ("_citySearch", cities.Where (p => p.Name.StartsWith (City)));
        }
        public JsonResult listByJson () {
            List<City> cities = new List<City> () {
                new City () { Name = "gharda2a", CreationDate = DateTime.Now },
                new City () { Name = "Luxor", CreationDate = DateTime.Now }
            };
            return Json (cities);
        }
        // GET: City/Details
        public ActionResult Details (int id) {

            if (id - 1 == null) {
                return NotFound ();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<City> cities = cmgr.Find (new City ());
            if (cities.First (p => p.Id == id) == null) {
                return NotFound ();
            }

            return View (cities.First (p => p.Id == id));
        }
        //Delete

        // GET: City/Delete/5
        public ActionResult Delete (int? id) {
            if (id == null) {
                return NotFound ();
            }
            List<City> cities = cmgr.Find (new City ());
            if (cities.First (p => p.Id == id) == null) {
                return NotFound ();
            }
            return View (cities.First (p => p.Id == id));
        }

        //------------------------------------------
        // POST: city/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed (int id) {
            cmgr.Remove (id);
            return RedirectToAction ("viewCity");
        }
        //create city
        //Get
        public IActionResult create () {
            //if i have another elements in another tables
            return View ();
        }

        //post

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create ([Bind (include: "Id,Name,CreationDate,OwnerId,LastModificationDate")] City city) {
            if (ModelState.IsValid) {
                cmgr.Add (city);
                return RedirectToAction ("ViewCity");
            }
            return View (city);
        }
        // GET: city/Edit
        public ActionResult Edit (int id) {
            if (id == null) {
                return NotFound ();
            }
            List<City> cities = cmgr.Find (new City ());
            if (cities[id] == null) {
                return NotFound ();
            }
            return View (cities[id]);
        }
        // POST: Cities/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ([Bind (include: "Id,Name,CreationDate,OwnerId,LastModificationDate,ModifierId")] City city) {
            if (ModelState.IsValid) {
                cmgr.Edit (city);
                return RedirectToAction ("ViewCity");
            }
            return View (city);
        }

    }
}