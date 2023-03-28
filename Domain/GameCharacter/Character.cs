using Domain.Models;
using Domain.Model.Character;

namespace Domain.GameCharacter
{
    public class Character : CharacterModel

    {
        public Character(int id, string name,double maxLife, double currentLife, double attack, double defence, CharacterRaceEnum characterRace,
            LevelModel level, string imageAddress)
        {
            Id = id;
            Name = name;
            Level = level;
            Attack = attack;
            MaxLife = maxLife;
            Defence = defence;
            CurrentLife = currentLife;
            Shield = new ShieldModel();
            ImageAddress = imageAddress;
            CharacterRace = characterRace;
            Armor = new List<ArmorModel>();
            Weapon = new List<WeaponModel>();
        }
    }
}
