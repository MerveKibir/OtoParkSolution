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
    
    public partial class Tarifes
    {
        public int ID { get; set; }
        public string AracTip { get; set; }
        public int TarifeTipId { get; set; }
        public string YıkamaTip { get; set; }
        public string TarifeAd { get; set; }
        public decimal YıkamaFiyat { get; set; }
        public decimal TarifeFiyat { get; set; }
        public System.DateTime Zaman { get; set; }
        public bool AktifMi { get; set; }
    }
}