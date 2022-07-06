using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ado.netDapperOrmProje.Models;
using Dapper;

namespace Ado.netDapperOrmProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View(DP.ReturnList<KategoriModel>("KategoriListele"));
        }

        [HttpGet]

        public ActionResult KtegoriEkle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@KategoriId", id);
                return View(DP.ReturnList<KategoriModel>("KategoriNoSirala", param).FirstOrDefault<KategoriModel>());
            }
        }
        [HttpPost]
        public ActionResult KtegoriEkle(KategoriModel mus)
        {
            //view olurken edit olanı seçiyoruz.

            DynamicParameters param = new DynamicParameters();
            param.Add("@KategoriId", mus.KategoriId);
            param.Add("@KategoriAd", mus.KategoriAd);
            

            DP.ExecuteWithoutReturn("KtegoriEkle", param);
            return RedirectToAction("Index");

        }
        public ActionResult KDelete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@KategoriId", id);
            DP.ExecuteWithoutReturn("KategoriSilNo", param);
            return RedirectToAction("Index");
        }
    }
}