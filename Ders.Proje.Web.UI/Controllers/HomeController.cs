using Ders.Proje.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders.Proje.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["LoginUser"] == null)
                return Redirect("/Giris");
            else
            {
                var usr = Session["LoginUser"] as User;
                ViewBag.usrID = usr.ID;
                return View();
            }
        }
    }
}