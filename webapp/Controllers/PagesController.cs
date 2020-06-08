using System.Collections.Generic;
using Bll;
using Dal.models;
using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers {
    public class PagesController : Controller {
        private ILanguageMgr mgr;

        public PagesController () {
            mgr = new LanguageMgr ();
        }



        public IActionResult Services () {
            return View ();
        }


        public IActionResult AddLang () {
            List<Language> langs = mgr.Find (new Language ());
            return View (langs);
        }

        public IActionResult Languages () {
            List<Language> langs = mgr.Find (new Language ());
            return View (langs);
        }

        // url: /pages/addLanguage
        [HttpPost] // we should discuss http methods
        public JsonResult AddLanguage (string name) {
            var newLang = new Language () { Name = name };
            mgr.Add (newLang);
            return Json (newLang);
        }

    }
}