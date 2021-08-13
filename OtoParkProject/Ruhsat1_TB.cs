namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ruhsat1_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Il { get; set; }

        [StringLength(25)]
        public string Ilce { get; set; }

        [StringLength(25)]
        public string Plaka { get; set; }

        [StringLength(25)]
        public string TescilSiraNo { get; set; }

        [StringLength(25)]
        public string Marka { get; set; }

        [StringLength(25)]
        public string TicariAd { get; set; }

        [StringLength(25)]
        public string Cins { get; set; }

        [StringLength(25)]
        public string MotorNo { get; set; }

        [StringLength(25)]
        public string SaseNo { get; set; }

        public int? NetAgirlik { get; set; }

        public int? KatarAgirligi { get; set; }

        public int? KoltukSayisi { get; set; }

        public int? SilindirHacmi { get; set; }

        [StringLength(25)]
        public string YakitCinsi { get; set; }

        [StringLength(25)]
        public string KullanimAmaci { get; set; }

        public DateTime? IlkTescilTarihi { get; set; }

        public DateTime? TescilTarihi { get; set; }

        [StringLength(25)]
        public string Tipi { get; set; }

        [StringLength(4)]
        public string ModelYili { get; set; }

        [StringLength(25)]
        public string AracSinifi { get; set; }

        [StringLength(25)]
        public string Rengi { get; set; }

        public decimal? AzamiYukluAgirlik { get; set; }

        public decimal? RoAzamiYukluAgirlik { get; set; }

        public int? AyaktaYolcuSayisi { get; set; }

        public int? MotorGucu { get; set; }

        public decimal? GucAgirlikOrt { get; set; }

        [StringLength(25)]
        public string TipOnayNo { get; set; }

        public int? Vekil { get; set; }

        public int? Cari { get; set; }

        public bool? AktifMi { get; set; }
    }
}
