using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUnit
    {
        public abstract UnitModel GiveWeapon(UnitModel unit, List<WeaponModel> weaponList);
        public abstract UnitModel GiveArmor(UnitModel unit, List<ArmorModel> armorList);
        public abstract UnitModel GiveShield(UnitModel unit, ShieldModel shield);
    }
}
