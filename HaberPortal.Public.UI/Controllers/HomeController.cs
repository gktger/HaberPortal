using HaberPortal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortal.Public.UI.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetSlider()
        {
            var haberler = db.Haber.Where(x => x.HaberTip.Adi == "Manset").OrderByDescending(x => x.YayinTarihi).Take(10);
            return View(haberler);
        }
        public ActionResult EnSonHaberler()
        {
            return View();
        }
        public ActionResult UstTab()
        {
            return View();
        }
            }
}