//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtoParkProject.Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ruhsat2_TB
    {
        public int ID { get; set; }
        public string KimlikVergiNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adresi { get; set; }
        public string AractaHakkiOlanlar { get; set; }
        public Nullable<System.DateTime> NoterSatisTarihi { get; set; }
        public string NoterSatisNo { get; set; }
        public string NoterAd { get; set; }
        public string OnaylayanSicilNo { get; set; }
        public string BelgeSeriNo { get; set; }
        public string DigerBilgiler { get; set; }
        public Nullable<int> Vekil { get; set; }
        public Nullable<int> Cari { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    }
}