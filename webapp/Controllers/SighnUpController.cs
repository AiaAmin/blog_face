using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll;
using Microsoft.AspNetCore.Mvc;
using Dal.models;

namespace webapp.Controllers
{
    public class SighnUpController : Controller
    {
        //call Data
        private ICityMgr cmgr;
        private ISkillMgr skmgr;
        private ILanguageMgr LangMgr;
        public SighnUpController()
        {
            cmgr = new CityMgr();
            skmgr = new SkillMgr();
            LangMgr = new LanguageMgr();
        }
        public IActionResult Search(string City)
        {
            List<City> cities = cmgr.Find(new City());
            return View(cities.Where(p => p.Name.StartsWith(City)));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}