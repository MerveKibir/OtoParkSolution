namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TrafikEkip_TB
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string EkipTanim { get; set; }

        [StringLength(50)]
        public string Karakol { get; set; }

        [StringLength(50)]
        public string Sube { get; set; }

        [StringLength(11)]
        public string Tel1 { get; set; }

        [StringLength(11)]
        public string Tel2 { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        [StringLength(100)]
        public string Adres { get; set; }

        public bool? AktifMi { get; set; }
    }
}
