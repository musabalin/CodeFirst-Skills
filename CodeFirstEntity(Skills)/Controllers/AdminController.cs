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

            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var result = c.Skills.Find(id);
            c.Skills.Remove(result);
            c.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var result = c.Skills.Find(id);
            return View("Update", result);
        }
      [HttpPost]
        public ActionResult Update(SKILLS s)
        {
            var result = c.Skills.Find(s.ID);
            result.Description = s.Description;
            result.Value = s.Value;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}