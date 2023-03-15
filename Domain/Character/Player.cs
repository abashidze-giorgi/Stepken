using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Characters
{
    public class Player: UnitModel
    {
        public double Gold { get; set; }
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

        public Player()
        {
            Gold = 10;
            Id = 1;
            Name = $"Human";
            Life = 350;
            Attack = 15;
            Defence = 15;
            Shield = new ShieldModel();
            Armor = new List<ArmorModel>();
            Weapon = new List<WeaponModel>();
            Character = CharacterRaceEnum.Human;
            ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\Character\human.jpg";
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


        private ZoneModel LegZone = new ZoneModel
        {
            ID = 2,
            IsProtected = false,
            IsAttacked = false,
            Name = "leg"
        };
        private ZoneModel BodyZone = new ZoneModel
        {
            ID = 3,
            IsProtected = false,
            IsAttacked = false,
            Name = "body"
        };
        private ZoneModel HeadZone = new ZoneModel
        {
            ID = 4,
            IsProtected = false,
            IsAttacked = false,
            Name = "head"
        };
    }
}
