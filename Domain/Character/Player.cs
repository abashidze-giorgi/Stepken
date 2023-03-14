using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Characters
{
    public class Player: UnitModel
    {
        private int Id = 1;
        private double Life = 350;
        private double Attack = 15;
        private double Defence = 15;
        private double MagicPower = 50;
        private ShieldModel Shield = new ShieldModel();
        private List<ArmorModel> Armor = new List<ArmorModel>();
        private List<WeaponModel> Weapon = new List<WeaponModel>();
        private MagicBonusModel MagicBonus = new MagicBonusModel();
        private CharacterRaceEnum Character = CharacterRaceEnum.Human;

        private string Name = $"Human";

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
