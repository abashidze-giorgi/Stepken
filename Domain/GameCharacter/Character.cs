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
        public Character(int id, string name,double maxLife, double currentLife, double attack, double defence, CharacterRaceEnum characterRace,
            LevelModel level, string imageAddress)
        {
            Id = id;
            Name = name;
            MaxLife = maxLife;
            CurrentLife = currentLife;
            Attack = attack;
            Defence = defence;
            CharacterRace = characterRace;
            Level = level;
            Shield = new ShieldModel();
            Weapon = new List<WeaponModel>();
            Armor = new List<ArmorModel>();
            ImageAddress = imageAddress;
        }
    }
}
