using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CodeFirstEntity_Skills_.Models.Classes;

namespace CodeFirstEntity_Skills_.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var values = c.Skills.ToList();

            return View(values);
        }
    }
}