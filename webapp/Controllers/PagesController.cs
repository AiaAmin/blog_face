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

        public IActionResult Home () {
            return View ();
        }

        public IActionResult Services () {
            return View ();
        }

        public IActionResult Aia () {
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

        // public IActionResult Index () {
        //     return View ();
        // }

        // [HttpGet]
        // public JsonResult Details () {
        //     //Creating List    
        //     List<Language> langs = new List<Language> () {
        //         //Adding records to list   
        //         new Language { Id = 3, Name = "german" },
        //         new Language { Id = 4, Name = "chinese" }
        //     };

        //     //return list as Json    
        //     return Json (langs, JsonRequestBehavior.AllowGet);
        // }
    }
}