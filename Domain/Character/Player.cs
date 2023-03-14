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
        private CharacterRaceEnum Character = CharacterRaceEnum.Humans;
        private string Name = $"{CharacterRaceEnum.Humans.ToString()}-1";
        private ZoneModel Leg = new ZoneModel();
        private ZoneModel Body = new ZoneModel();
        private ZoneModel Head = new ZoneModel();
    }
}
