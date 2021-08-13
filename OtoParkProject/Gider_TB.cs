namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gider_TB
    {
        public int ID { get; set; }

        public decimal? Toplam { get; set; }

        [StringLength(100)]
        public string Aciklama { get; set; }

        public DateTime? Tarih { get; set; }

        public bool? AktifMi { get; set; }
    }
}
