using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ArmorModel: AmmunitionModel
    {
        public double DefensePower { get; set; }
        public double Penetration { get; set; }
        public double Luck { get; set; }
    }
}


