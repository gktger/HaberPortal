

using HaberPortal.BLL;
using System.Linq;
using System.Web.Mvc;

namespace HaberlerPortal.Public.UI.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MansetGetir()
        {
            var model = AnaSayfaBLL.MansetGetir();
            return View(model);
        }
        public ActionResult EnSonHaberler()
        {
            var model = AnaSayfaBLL.EnsonHaberGetir();
            return View(model);
        }
        public ActionResult UstTab()
        {
            return View();
        }
        public ActionResult Tab_VideoGetir()
        {

            return View();
        }
    }
}