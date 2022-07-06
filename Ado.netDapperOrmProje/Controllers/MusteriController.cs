using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ado.netDapperOrmProje.Models;
using Dapper;

namespace Ado.netDapperOrmProje.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Index()
        {
            return View(DP.ReturnList<MusteriModel>("MusteriListele"));
        }
        [HttpGet]

        public ActionResult MusteriEkle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MusteriId", id);
                return View(DP.ReturnList<MusteriModel>("MusteriNoSirala", param).FirstOrDefault<MusteriModel>());
            }
        }
        [HttpPost]
        public ActionResult MusteriEkle(MusteriModel ekle)
        {
            //view olurken edit olanı seçiyoruz.

            DynamicParameters param = new DynamicParameters();
            param.Add("@MusteriId", ekle.MusteriId);
            param.Add("@MusteriAd", ekle.MusteriAd);
            param.Add("@MusteriSoyad", ekle.MusteriSoyad);



            DP.ExecuteWithoutReturn("MusteriEkle", param);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MusteriId", id);
            DP.ExecuteWithoutReturn("MusteriSilNo", param);
            return RedirectToAction("Index");
        }
    }
}