using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Models
{
    public class CekiciFirma
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FirmaAd { get; set; }
        public string VergiDaireNo { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string CepTel { get; set; }
        public string Adres { get; set; }
        public bool AktifMi { get; set; }
    }
}
