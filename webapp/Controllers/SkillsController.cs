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
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<Skill> skills = skmgr.Find(new Skill());
                if (skills[0] == null)
                {
                    return NotFound();
                }

            return View(skills[0]);
        }


    }
}