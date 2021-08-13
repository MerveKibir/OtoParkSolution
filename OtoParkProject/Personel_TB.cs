namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personel_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string TCNo { get; set; }

        [StringLength(12)]
        public string SicilNo { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(8)]
        public string PerNo { get; set; }

        public DateTime? DogumTar { get; set; }

        [StringLength(50)]
        public string DogumYer { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(25)]
        public string KullaniciAd { get; set; }

        [StringLength(32)]
        public string Parola { get; set; }

        public bool? SirketMi { get; set; }

        public int? Sube1 { get; set; }

        public int? Sube2 { get; set; }

        public int? Sube3 { get; set; }

        public bool? AktifMi { get; set; }
    }
}
