using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Models
{
    public class Sirket
    {
        public int ID { get; set; }
        public string SirketAd { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Faks { get; set; }
        public string Yetkili { get; set; }
        public string Adres { get; set; }
        public string KullaniciAd { get; set; }
        public string Parola { get; set; }
        public bool AktifMi { get; set; }
    }
}
