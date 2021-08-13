using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Models
{
    public class Tarife
    {
        public int ID { get; set; }
        public string AracTip { get; set; }
        public int TarifeTipId { get; set; }
        public string YıkamaTip { get; set; }
        public string TarifeAd { get; set; }
        public decimal YıkamaFiyat { get; set; }
        public decimal TarifeFiyat { get; set; }
        public DateTime Zaman { get; set; }
        public bool AktifMi { get; set; }

    }
}
