namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KasaHareketleri_TB
    {
        public int ID { get; set; }

        public bool? GelirMi { get; set; }

        public int? GelirTip { get; set; }

        public int? GiderTip { get; set; }
    }
}
