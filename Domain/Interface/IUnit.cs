using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnit
    {
        public abstract UnitModel GiveWeapon(UnitModel unit, List<WeaponModel> weaponList);
        public abstract UnitModel GiveArmor(UnitModel unit, List<ArmorModel> armorList);
        public abstract UnitModel GiveShield(UnitModel unit, ShieldModel shield);
    }
}
