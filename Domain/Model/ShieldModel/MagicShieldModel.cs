namespace Domain.Models.ShieldModels
{
    public class MagicShieldModel : ShieldModel
    {
        public double MagicResistance { get; set; } // какое сопротивление щит оказывает против магических атак
        public double SpellSpending { get; set; } // сколько силы заклинаний тратир щит для отражения атаки.
    }
}
