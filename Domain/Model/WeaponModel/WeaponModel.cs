using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class WeaponModel: AmmunitionModel
    {
        public double AttackPower { get; set; }
        public double Accuracy { get; set; }
    }

}
