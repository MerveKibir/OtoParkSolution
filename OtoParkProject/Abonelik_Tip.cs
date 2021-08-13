namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abonelik_Tip
    {
        public int ID { get; set; }

        public string AbonelikTip { get; set; }

        public bool AktifMi { get; set; }
    }
}
