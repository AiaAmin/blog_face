﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bll;
using Dal.models;
using Microsoft.AspNetCore.Razor.Language;

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
    }
}