using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Models
{
    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public string SicilNo { get; set; }
        public string Tel { get; set; }
        public string PerNo { get; set; }
        public DateTime DogumTar { get; set; }
        public string DogumYer { get; set; }
        public string Adres { get; set; }
        public string KullaniciAd { get; set; }
        public string Parola { get; set; }
        public bool SirketMi { get; set; }
        public bool Sube1 { get; set; }
        public bool Sube2 { get; set; }
        public bool Sube3 { get; set; }
        public bool AktifMi { get; set; }
    }
}
