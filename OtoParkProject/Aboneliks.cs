namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aboneliks
    {
        public int ID { get; set; }

        public int AbonelikTipId { get; set; }

        public int TarifeId { get; set; }

        public int CariId { get; set; }

        public DateTime AboneBasTar { get; set; }

        public DateTime AboneBitTar { get; set; }

        public bool AktifMi { get; set; }
    }
}
