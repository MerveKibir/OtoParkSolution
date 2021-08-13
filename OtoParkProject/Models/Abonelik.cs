using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Models
{
    public class Abonelik
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
