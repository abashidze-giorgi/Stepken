using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MagicalWeaponModel : WeaponModel
    {
        public double MagicAttackPower { get; set; }
        public double SpellSpending { get; set; }
    }
}
