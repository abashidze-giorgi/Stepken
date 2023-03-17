using Domain.Interfaces;
using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class CharacterModel : ICharacter
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Life { get; set; }
        public virtual double Attack { get; set; }
        public virtual double Defence { get; set; }
        public virtual CharacterRaceEnum Character { get; set; }
        public virtual ShieldModel Shield { get; set; } = new ShieldModel();
        public virtual List<WeaponModel> Weapon { get; set; } = new List<WeaponModel>();
        public virtual List<ArmorModel> Armor { get; set; } = new List<ArmorModel>();
        public virtual string ImageAddress { get; set; }


        public virtual CharacterModel GiveArmor(CharacterModel unit, List<ArmorModel> armorList)
        {
            foreach (var a in armorList)
            {
                unit.Armor.Add(a);
            }
            return unit;
        }

        public virtual CharacterModel GiveShield(CharacterModel unit, ShieldModel shield)
        {
            unit.Shield = shield;
            return unit;
        }

        public virtual CharacterModel GiveWeapon(CharacterModel unit, List<WeaponModel> weaponList)
        {
            foreach (var w in weaponList)
            {
                unit.Weapon.Add(w);
            }
            return unit;
        }
    }


}
