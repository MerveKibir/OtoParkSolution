namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aracs
    {
        public int ID { get; set; }

        public string AracTanim { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public string Renk { get; set; }

        public string Plaka { get; set; }

        public string EhliyetSinifi { get; set; }

        public decimal KmUcret { get; set; }

        public int AracTipId { get; set; }

        public int CariId { get; set; }

        public int AbonelikId { get; set; }

        public int CekiciFirmaId { get; set; }

        public int YediEminGirisKayitId { get; set; }

        public string Aciklama { get; set; }

        public bool YediEminMi { get; set; }

        public bool AktifMi { get; set; }
    }
}
