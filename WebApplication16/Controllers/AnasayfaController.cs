using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models.Siniflar;

namespace WebApplication16.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        context db = new context();
        public ActionResult Index()
        {
            var degerler = db.anasayfas.ToList();
            return View(degerler);
        }
        public  PartialViewResult ikonlar()
        {
            var degerler = db.ikonlars.ToList();
            return PartialView(degerler);
        }
    }
}