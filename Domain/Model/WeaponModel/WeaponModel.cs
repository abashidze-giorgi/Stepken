namespace Domain.Models
{
    public class WeaponModel : AmmunitionModel
    {
        public virtual double AttackPower { get; set; }
        public virtual double Fault { get; set; }
    }

}
