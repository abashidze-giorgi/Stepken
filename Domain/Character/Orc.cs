using Domain.Model.Character;
using Domain.Models;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Character
{
    public class Orc : CharacterModel
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override double Life { get => base.Life; set => base.Life = value; }
        public override double Attack { get => base.Attack; set => base.Attack = value; }
        public override double Defence { get => base.Defence; set => base.Defence = value; }
        public override CharacterRaceEnum Character { get => base.Character; set => base.Character = value; }
        public override EnemyLevelModel Level { get => base.Level; set => base.Level = value; }
        public override ShieldModel Shield { get => base.Shield; set => base.Shield = value; }
        public override List<WeaponModel> Weapon { get => base.Weapon; set => base.Weapon = value; }
        public override List<ArmorModel> Armor { get => base.Armor; set => base.Armor = value; }
        public override string ImageAddress { get => base.ImageAddress; set => base.ImageAddress = value; }

        public Orc()
        {
            Id = 4;
            Name = "Orc";
            Life = 640;
            Attack = 32;
            Defence = 24;
            Character = CharacterRaceEnum.Orc;
            Level = EnemyLevelModel.Level_1;
            Shield = new ShieldModel();
            Weapon = new List<WeaponModel>();
            Armor = new List<ArmorModel>();
            ImageAddress = $"{GetFolderPath.GetCharacterFolderPath()}\\Kobold.jpg";
        }

        public override CharacterModel GiveArmor(CharacterModel unit, List<ArmorModel> armorList)
        {
            return base.GiveArmor(unit, armorList);
        }

        public override CharacterModel GiveShield(CharacterModel unit, ShieldModel shield)
        {
            return base.GiveShield(unit, shield);
        }

        public override CharacterModel GiveWeapon(CharacterModel unit, List<WeaponModel> weaponList)
        {
            return base.GiveWeapon(unit, weaponList);
        }
    }
}
