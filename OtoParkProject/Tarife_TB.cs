namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tarife_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string AracTip { get; set; }

        public int? TarifeTipId { get; set; }

        [StringLength(25)]
        public string TarifeAd { get; set; }

        [StringLength(25)]
        public string YıkamaTip { get; set; }

        public decimal? YıkamaFiyat { get; set; }

        public decimal? TarifeFiyat { get; set; }

        public int? Zaman { get; set; }

        public bool? AktifMi { get; set; }
    }
}
