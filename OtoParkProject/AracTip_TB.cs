namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AracTip_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string AracTip { get; set; }

        public bool? AktifMi { get; set; }
    }
}