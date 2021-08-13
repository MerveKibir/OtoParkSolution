namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Surucu_TB
    {
        public int ID { get; set; }

        public int? CekiciFirmaId { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string CepTel { get; set; }

        [StringLength(10)]
        public string EhliyetSinifi { get; set; }

        [StringLength(10)]
        public string EhliyetBelgeNo { get; set; }

        public bool? AktifMi { get; set; }
    }
}
