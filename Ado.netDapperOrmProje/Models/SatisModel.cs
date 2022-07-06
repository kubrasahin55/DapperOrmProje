using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ado.netDapperOrmProje.Models
{
    public class SatisModel
    {
        public int SatısId { get; set; }
        public int Urun { get; set; }
        public int Musteri { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}