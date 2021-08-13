namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subeler_TB
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SubeAd { get; set; }

        [StringLength(11)]
        public string Tel1 { get; set; }

        [StringLength(11)]
        public string Tel2 { get; set; }

        [StringLength(11)]
        public string Faks { get; set; }

        [StringLength(25)]
        public string Yetkili { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(25)]
        public string KullaniciAd { get; set; }

        [StringLength(32)]
        public string Parola { get; set; }

        public int? Kapasite { get; set; }

        public bool? AnaSubeMi { get; set; }

        public int? SirketId { get; set; }

        public bool? AktifMi { get; set; }
    }
}
