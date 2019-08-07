using Ders.Proje.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders.Proje.Web.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [Route("Giris")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Giris")]
        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            using (var db = new MyDB())
            {
                var usr = db.User.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
                if (usr != null)
                {
                    //Gİriş Başarılı
                    Session["LoginUser"] = usr;
                    return Redirect("/");
                }
            }
            return View();
        }
    }
}