using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class ShieldModel : AmmunitionModel
    {
        public virtual double Defence { get; set; } // сила защиты
        public virtual double BlockChance { get; set; } // процент шанса отражения удара.
        public virtual double AttackPenalty { get; set; } // насколько щит влияет на силу атаки юнита
        public virtual List<ZoneModel> Zone { get; set; } //лист зон защиты 
    }
}
