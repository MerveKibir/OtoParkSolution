namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ruhsat2_TB
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string KimlikVergiNo { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(225)]
        public string Adresi { get; set; }

        [StringLength(225)]
        public string AractaHakkiOlanlar { get; set; }

        public DateTime? NoterSatisTarihi { get; set; }

        [StringLength(25)]
        public string NoterSatisNo { get; set; }

        [StringLength(25)]
        public string NoterAd { get; set; }

        [StringLength(25)]
        public string OnaylayanSicilNo { get; set; }

        [StringLength(25)]
        public string BelgeSeriNo { get; set; }

        [StringLength(225)]
        public string DigerBilgiler { get; set; }

        public int? Vekil { get; set; }

        public int? Cari { get; set; }

        public bool? AktifMi { get; set; }
    }
}
