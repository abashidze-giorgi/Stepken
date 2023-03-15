using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Characters
{
    public class Player: UnitModel
    {
        public double Gold { get; set; }
        public Player()
        {
            Gold = 10;
            Id = 1;
            Name = $"Human";
            Life = 350;
            Attack = 15;
            Defence = 15;
            Mana = 50;
            Shield = new ShieldModel();
            Armor = new List<ArmorModel>();
            Weapon = new List<WeaponModel>();
            MagicBonus = new MagicBonusModel();
            Character = CharacterRaceEnum.Human;
            ImageAddress = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\Character\human.jpg";
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
            IsProtected= false,
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
