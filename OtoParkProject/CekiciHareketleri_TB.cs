namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CekiciHareketleri_TB
    {
        public int ID { get; set; }

        public int? AracId { get; set; }

        public int? SurucuId { get; set; }

        [StringLength(100)]
        public string AracTanim { get; set; }

        [StringLength(100)]
        public string AracAlımYeri { get; set; }

        public DateTime? GetirmeZamani { get; set; }

        public decimal? Mesafe { get; set; }

        [StringLength(5)]
        public string Birim { get; set; }

        public decimal? EkUcret { get; set; }

        [StringLength(100)]
        public string UcretAciklama { get; set; }

        public decimal? ToplamUcret { get; set; }

        public bool? AktifMi { get; set; }
    }
}
