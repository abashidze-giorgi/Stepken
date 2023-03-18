using Domain.Interfaces;
using Domain.Model.Character;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GameCharacter
{
    public class Character : CharacterModel

    {
        public Character(int id, string name, double life, double attack, double defence, CharacterRaceEnum characterRace,
            LevelModel level, string imageAddress)
        {
            Id = id;
            Name = name;
            Life = life;
            Attack = attack;
            Defence = defence;
            CharacterRace = characterRace;
            Level = level;
            Shield = new ShieldModel();
            Weapon = new List<WeaponModel>();
            Armor = new List<ArmorModel>();
            ImageAddress = imageAddress;
        }

        public override Models.CharacterModel GiveArmor(Models.CharacterModel unit, List<ArmorModel> armorList)
        {
            return base.GiveArmor(unit, armorList);
        }

        public override Models.CharacterModel GiveShield(Models.CharacterModel unit, ShieldModel shield)
        {
            return base.GiveShield(unit, shield);
        }

        public override Models.CharacterModel GiveWeapon(Models.CharacterModel unit, List<WeaponModel> weaponList)
        {
            return base.GiveWeapon(unit, weaponList);
        }
    }
}
