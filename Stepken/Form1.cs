using Domain.Models;
using Domain.Characters;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player player; 
        public Form1()
        {
            InitializeComponent();
            GetPlayer();
        }

        private void GetPlayer()
        {
            player = new Player
            {
                Id = 1,
                Life = 350,
                Attack = 15,
                Defence = 15,
                MagicPower = 50,
                Shield = new ShieldModel(),
                Armor = new List<ArmorModel>(),
                Weapon = new List<WeaponModel>(),
                MagicBonus = new MagicBonusModel(),
                Character = CharacterRaceEnum.Humans,
                Name = $"{CharacterRaceEnum.Humans.ToString()}-1"
            };
        }
    }
}