using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CodeFirstEntity_Skills_.Models.Classes;

namespace CodeFirstEntity_Skills_.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            
            var result = c.Skills.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(SKILLS s)
        {
            c.Skills.Add(s);
            c.SaveChanges();         

            return View();
        }
    }
}