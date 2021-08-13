namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subes
    {
        public int ID { get; set; }

        public string SubeAd { get; set; }

        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string Faks { get; set; }

        public string Yetkili { get; set; }

        public string Adres { get; set; }

        public bool Kapasite { get; set; }

        public bool AnaSubeMi { get; set; }

        public int SirketId { get; set; }

        public string KullaniciAd { get; set; }

        public string Parola { get; set; }

        public bool AktifMi { get; set; }
    }
}
