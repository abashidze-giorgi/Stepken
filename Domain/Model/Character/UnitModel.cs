using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UnitModel: IUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CharacterRaceEnum Character {get; set; }
        public double Life { get; set; }
        public double MagicPower { get; set; }
        public double Attack { get; set; }
        public double Defence { get; set; }
        public List<WeaponModel> Weapon { get; set; } = new List<WeaponModel>();
        public List<ArmorModel> Armor { get; set; } = new List<ArmorModel>();
        public ShieldModel Shield { get; set; } = new ShieldModel();
        public MagicBonusModel MagicBonus { get; set; } = new MagicBonusModel();

        public UnitModel GiveArmor(UnitModel unit, List<ArmorModel> armorList)
        {
            
            foreach(var a in armorList)
            {
                unit.Armor.Add(a);
            }
            return unit;
        }

        public UnitModel GiveMagicBonus(UnitModel unit, MagicBonusModel bonus)
        {
            unit.MagicBonus = bonus;
            return unit;
        }

        public UnitModel GiveShield(UnitModel unit, ShieldModel shield)
        {
            unit.Shield = shield;
            return unit;
        }

        public UnitModel GiveWeapon(UnitModel unit, List<WeaponModel> weaponList)
        {
            foreach (var w in weaponList)
            {
                unit.Weapon.Add(w);
            }
            return unit;
        }
    }


}
