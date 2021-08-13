namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CekiciFirma_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(25)]
        public string FirmaAd { get; set; }

        [StringLength(25)]
        public string VergiDaireNo { get; set; }

        [StringLength(11)]
        public string Tel1 { get; set; }

        [StringLength(11)]
        public string Tel2 { get; set; }

        [StringLength(11)]
        public string CepTel { get; set; }

        [StringLength(100)]
        public string Adres { get; set; }

        public bool? AktifMi { get; set; }
    }
}
