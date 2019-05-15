

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
        public ActionResult GetSlider()
        {
            
            return View(AnaSayfaBLL.MansetGetir());
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