namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YediEminHasar_TB
    {
        public int ID { get; set; }

        public bool? InsanMi { get; set; }

        public bool? AracMi { get; set; }

        public bool? OlumMu { get; set; }

        public bool? YaralanmaMi { get; set; }

        public bool? VekilMi { get; set; }

        [StringLength(25)]
        public string Plaka { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Kimlik { get; set; }

        public int? YediEminId { get; set; }
    }
}
