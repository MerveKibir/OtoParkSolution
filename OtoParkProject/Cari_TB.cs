namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cari_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string TCNo { get; set; }

        [StringLength(19)]
        public string DogumTar { get; set; }

        [StringLength(20)]
        public string IsTel { get; set; }

        [StringLength(20)]
        public string EvTel { get; set; }

        [StringLength(20)]
        public string CepTel { get; set; }

        [StringLength(75)]
        public string IsYer { get; set; }

        [StringLength(12)]
        public string AboneNo { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        public bool? AktifMi { get; set; }
    }
}
