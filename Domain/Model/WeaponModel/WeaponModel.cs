namespace Domain.Models
{
    public abstract class WeaponModel : AmmunitionModel
    {
        public double AttackPower { get; set; }
        public double Fault { get; set; }
    }

}
