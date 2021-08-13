namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fatura_TB
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string FaturaNo { get; set; }

        public int? FaturaTip { get; set; }

        public DateTime? Tarih { get; set; }

        public decimal? Nakit { get; set; }

        public decimal? KKart { get; set; }

        public decimal? Toplam { get; set; }

        public bool? AktifMi { get; set; }

        public virtual FaturaTip_TB FaturaTip_TB { get; set; }
    }
}
