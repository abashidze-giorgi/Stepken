using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class ShieldModel : AmmunitionModel
    {
        public double Defence { get; set; } // сила защиты
        public double BlockChance { get; set; } // процент шанса отражения удара.
        public double AttackPenalty { get; set; } // насколько щит влияет на силу атаки юнита
        public List<ZoneModel> Zone { get; set; } = new List<ZoneModel>(); //лист зон защиты 
    }
}
