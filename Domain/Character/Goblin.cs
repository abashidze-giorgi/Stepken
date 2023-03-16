using Domain.Models;
using Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Character
{
    public class Goblin : UnitModel
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override double Life { get => base.Life; set => base.Life = value; }
        public override double Attack { get => base.Attack; set => base.Attack = value; }
        public override double Defence { get => base.Defence; set => base.Defence = value; }
        public override CharacterRaceEnum Character { get => base.Character; set => base.Character = value; }
        public override ShieldModel Shield { get => base.Shield; set => base.Shield = value; }
        public override List<WeaponModel> Weapon { get => base.Weapon; set => base.Weapon = value; }
        public override List<ArmorModel> Armor { get => base.Armor; set => base.Armor = value; }
        public override string ImageAddress { get => base.ImageAddress; set => base.ImageAddress = value; }

        public Goblin()
        {
            Id = 2;
            Name = "Goblin";
            Life = 450;
            Attack = 17;
            Defence = 16;
            Character = CharacterRaceEnum.Goblin;
            Shield = new ShieldModel();
            Weapon = new List<WeaponModel>();
            Armor = new List<ArmorModel>();
            ImageAddress = $"{GetFolderPath.GetCharacterFolderPath()}\\Goblin.jpg";
        }

        public override UnitModel GiveArmor(UnitModel unit, List<ArmorModel> armorList)
        {
            return base.GiveArmor(unit, armorList);
        }

        public override UnitModel GiveShield(UnitModel unit, ShieldModel shield)
        {
            return base.GiveShield(unit, shield);
        }

        public override UnitModel GiveWeapon(UnitModel unit, List<WeaponModel> weaponList)
        {
            return base.GiveWeapon(unit, weaponList);
        }
    }
}
