namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caris
    {
        public int ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TCNo { get; set; }

        public string DogumTar { get; set; }

        public string IsTel { get; set; }

        public string EvTel { get; set; }

        public string CepTel { get; set; }

        public string IsYer { get; set; }

        public string AboneNo { get; set; }

        public string Adres { get; set; }

        public bool AktifMi { get; set; }
    }
}
