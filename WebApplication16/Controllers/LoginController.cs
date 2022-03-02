using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication16.Models.Siniflar;

namespace WebApplication16.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        context db = new context();
        
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(admin ad)
        {
            var bilgiler = db.admins.FirstOrDefault(x => x.kullaniciad == ad.kullaniciad && x.sifre == ad.sifre);
            if(bilgiler !=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciad, false);
                Session["kullaniciad"] = bilgiler.kullaniciad.ToString();
                return RedirectToAction("Index", "admin");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");

        }

    }
}