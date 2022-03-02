using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models.Siniflar;

namespace WebApplication16.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        context db = new context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.anasayfas.ToList();

            return View(degerler);
        }
        public ActionResult AnasayfaGetir(int id)
        {
            var anasayfa = db.anasayfas.Find(id);
            return View("AnasayfaGetir",anasayfa);


        }
        public ActionResult AnasayfaGuncelle(Anasayfa x )
        {
            var a= db.anasayfas.Find(x.id);
            a.isim = x.isim;
            a.profil = x.profil;
            a.iletisim = x.iletisim;
            a.unvan = x.unvan;
            a.aciklama = x.aciklama;
            db.SaveChanges();

            return RedirectToAction("Index");


        }
        public ActionResult ikonlistesi()
        {
            var degerler = db.ikonlars.ToList();
            return View(degerler);

        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            db.ikonlars.Add(p);
            db.SaveChanges();
            return RedirectToAction("ikonlistesi");
        }
        public ActionResult ikongetir(int id)
        {
            var ikg = db.ikonlars.Find(id);
            return View( "ikongetir",ikg);
        }
        public ActionResult ikonguncelle(ikonlar x)
        {
            var ikg = db.ikonlars.Find(x.id);
            ikg.ikonad = x.ikonad;
            ikg.link = x.link;
            db.SaveChanges();
            return RedirectToAction("ikonlistesi");


        }
        public ActionResult Sil(int id)
        {
            var sl = db.ikonlars.Find(id);
            db.ikonlars.Remove(sl);
            db.SaveChanges();
            return RedirectToAction("ikonlistesi");       
        }

    }
}