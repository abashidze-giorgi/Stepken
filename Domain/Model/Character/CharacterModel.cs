using Domain.GameCharacter;
using Domain.Interfaces;
using Domain.Model.Character;
using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class CharacterModel : ICharacter
    {
        public virtual int Id { get; set; } = 0;
        public virtual string? Name { get; set; }
        public virtual double Life { get; set; } = 0;
        public virtual double Attack { get; set; } = 0;
        public virtual double Defence { get; set; } = 0;
        public virtual CharacterRaceEnum? CharacterRace { get; set; }
        public virtual LevelModel? Level { get; set; }
        public virtual ShieldModel? Shield { get; set; }
        public virtual List<WeaponModel>? Weapon { get; set; }
        public virtual List<ArmorModel>? Armor { get; set; }
        public virtual string? ImageAddress { get; set; }


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
