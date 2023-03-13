using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ShieldModel : AmmunitionModel
    {
        public double Protection { get; set; } // сила защиты
        public double BlockChance { get; set; } // процент шанса отражения удара.
        public double AttackPenalty { get; set; } // насколько щит влияет на силу атаки юнита
    }
}
