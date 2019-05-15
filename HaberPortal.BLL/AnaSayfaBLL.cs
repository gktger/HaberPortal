using HaberPortal.DAL;
using HaberPortal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.BLL
{

    public static class AnaSayfaBLL
    {
       
        static DataContext db = new DataContext();

        public static List<Haber> MansetGetir()
        {
            var haberler = db.Haber.Where(x => x.HaberTip.Adi == "Manset").OrderByDescending(x => x.YayinTarihi).Take(10);
            return haberler.ToList();
        }
    }
}
