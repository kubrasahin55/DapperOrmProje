using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ado.netDapperOrmProje.Models
{
    public class UrunModel
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public int UrunKategori { get; set; }

        public decimal Fiyat { get; set; }
        public int Stok { get; set; }



    }
}