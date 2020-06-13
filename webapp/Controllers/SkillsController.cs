using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Dal.models;
using Bll;
using System.Net;
namespace webapp.Controllers

{

    public class SkillsController : Controller
    {
        private ISkillMgr skmgr;
        public SkillsController()
        {
            skmgr = new SkillMgr();
        }
        public IActionResult ViewSkills()
        {

            List<Skill> skills = skmgr.Find(new Skill());
            return View(skills);
        }
        // GET: Skills/Details
        public ActionResult Details(int id)
        {
            id -= 1;
            if (id == null)
            {
                return NotFound();
            }

            List<Skill> skills = skmgr.Find(new Skill());
            foreach(Skill skill in skills)
            {
                if (skills[id] == null)
                {
                    return NotFound();
                }

                return View(skills[id]);
            }
            return View(skills[id]);
        }
        //Create
        //Get
        public PartialViewResult _Create()
        {
          
            return PartialView();
        }


    }
}