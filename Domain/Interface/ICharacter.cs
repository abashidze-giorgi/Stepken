using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICharacter
    {
        public abstract CharacterModel GiveWeapon(CharacterModel unit, List<WeaponModel> weaponList);
        public abstract CharacterModel GiveArmor(CharacterModel unit, List<ArmorModel> armorList);
        public abstract CharacterModel GiveShield(CharacterModel unit, ShieldModel shield);
    }
}
