namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EkipPolis_TB
    {
        public int ID { get; set; }

        public int? TrafikEkipId { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Tel1 { get; set; }

        [StringLength(11)]
        public string CepTel { get; set; }

        [StringLength(20)]
        public string SicilNo { get; set; }

        [StringLength(20)]
        public string TelsizKodu { get; set; }

        [StringLength(20)]
        public string Birim { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public bool? AmirMi { get; set; }

        public bool? AktifMi { get; set; }
    }
}
