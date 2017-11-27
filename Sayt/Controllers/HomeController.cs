using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sayt.Models;
namespace Sayt.Controllers
{
    public class HomeController : Controller
    {
        TaylorEntities db = new TaylorEntities();
        public ActionResult Index()
        {
            ViewBag.Abouts = db.Abouts.First();
            return View();
        }

    }
}