namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Odeme_TB
    {
        public int ID { get; set; }

        public int? CariId { get; set; }

        public decimal? Odenecek { get; set; }

        public decimal? Odenen { get; set; }

        public decimal? Kalan { get; set; }

        public decimal? KKart { get; set; }

        public decimal? Nakit { get; set; }

        public bool? AktifMi { get; set; }
    }
}
