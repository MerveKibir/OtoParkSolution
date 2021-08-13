namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YediEminCikisKayit_TB
    {
        public int ID { get; set; }

        public DateTime? CikisBelgeTarihi { get; set; }

        [StringLength(25)]
        public string CikisBelgeNo { get; set; }

        public DateTime? CikisZamani { get; set; }

        [StringLength(25)]
        public string CikisTalimatBirimi { get; set; }

        [StringLength(25)]
        public string CikisTalimatEkibi { get; set; }

        public int? TeslimEdenPersonel { get; set; }

        public int? TeslimAlanVekil { get; set; }

        public int? TeslimAlanCari { get; set; }

        [StringLength(125)]
        public string AracCikisAciklama { get; set; }

        [StringLength(25)]
        public string AracPlaka { get; set; }

        [StringLength(25)]
        public string FaturaNo { get; set; }

        public decimal? OtoparkUcret { get; set; }

        public decimal? CekiciUcret { get; set; }

        public decimal? ToplamUcret { get; set; }

        public bool? AktifMi { get; set; }
    }
}
