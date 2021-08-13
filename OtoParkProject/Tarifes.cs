namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tarifes
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
