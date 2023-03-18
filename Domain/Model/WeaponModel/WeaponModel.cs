namespace Domain.Models
{
    public abstract class WeaponModel : AmmunitionModel
    {
        public virtual double AttackPower { get; set; }
        public virtual double Fault { get; set; }
    }

}
