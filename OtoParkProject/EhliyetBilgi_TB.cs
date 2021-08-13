namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EhliyetBilgi_TB
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }

        [StringLength(25)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Kimlik { get; set; }

        [StringLength(11)]
        public string VerilenIl { get; set; }

        [StringLength(11)]
        public string VerilenIlce { get; set; }

        [StringLength(25)]
        public string BelgeNo { get; set; }

        public DateTime? VerTarih { get; set; }

        [StringLength(25)]
        public string KulCihPro { get; set; }

        [StringLength(25)]
        public string Sinif { get; set; }

        [StringLength(25)]
        public string Il { get; set; }

        [StringLength(25)]
        public string Ilce { get; set; }

        [StringLength(25)]
        public string Mahalle { get; set; }

        [StringLength(25)]
        public string Koy { get; set; }

        public int? Cilt { get; set; }

        [StringLength(25)]
        public string Kutuk { get; set; }

        [StringLength(25)]
        public string Sayfa { get; set; }

        [StringLength(25)]
        public string BabaAdi { get; set; }

        [StringLength(25)]
        public string AnneAdi { get; set; }

        [StringLength(25)]
        public string DogumYeri { get; set; }

        public DateTime? DogumTarihi { get; set; }

        [StringLength(5)]
        public string KanGrubu { get; set; }

        [StringLength(25)]
        public string Duzenleyen { get; set; }

        public bool? VekilMi { get; set; }

        public bool? SahipMi { get; set; }

        public int? AracId { get; set; }

        public bool? AktifMi { get; set; }
    }
}
