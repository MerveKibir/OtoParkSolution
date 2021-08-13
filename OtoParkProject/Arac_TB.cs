namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Arac_TB
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string AracTanim { get; set; }

        [StringLength(25)]
        public string Marka { get; set; }

        [StringLength(25)]
        public string Model { get; set; }

        [StringLength(25)]
        public string Renk { get; set; }

        [StringLength(25)]
        public string Plaka { get; set; }

        public int? AracTipId { get; set; }

        public int? CariId { get; set; }

        public int? AbonelikId { get; set; }

        [StringLength(10)]
        public string EhliyetSinifi { get; set; }

        public decimal? KmUcret { get; set; }

        public int? CekiciFirmaId { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public bool? YediEminMi { get; set; }

        public int? YediEminGirisKayitId { get; set; }

        public bool? AktifMi { get; set; }
    }
}
