namespace OtoParkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YediEminGirisKayit_TB
    {
        public int ID { get; set; }

        public DateTime? Evrak { get; set; }

        [StringLength(15)]
        public string EvrakNo { get; set; }

        public DateTime? GirisZaman { get; set; }

        public bool? KazaliMi { get; set; }

        [StringLength(50)]
        public string KurumIbraz { get; set; }

        [StringLength(15)]
        public string IbrazEvrakNo { get; set; }

        [StringLength(30)]
        public string Kurum { get; set; }

        public bool? AracliKazaMi { get; set; }

        public bool? OlumluKazaMi { get; set; }

        [StringLength(30)]
        public string TrafikBilgisi { get; set; }

        [StringLength(30)]
        public string TrafikMenBilgisi { get; set; }

        [StringLength(75)]
        public string MenAdresi { get; set; }

        [StringLength(15)]
        public string MenZamani { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public int? TarifeId { get; set; }

        public bool? FiiliHacizMi { get; set; }

        [StringLength(200)]
        public string AracEkipman { get; set; }

        [StringLength(200)]
        public string AracEmanet { get; set; }

        public int? TrafikEkipId { get; set; }

        public int? PersonelId { get; set; }

        public int? CekiciHareketleriId { get; set; }

        public int? CekiciId { get; set; }
    }
}
