using Domain.Interface;
using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Service
{
    public class Battle : IBattle
    {
        public double GetBattleResult(ZoneModel zone, double hitPower, double defencePower)
        {
            throw new NotImplementedException();
        }

        public double GetDefencePower(CharacterModel unit)
        {
            double unitDefence = unit.Defence;
            double armorDefence = 0;
            foreach(var arm in unit.Armor)
            {
                armorDefence += unit.Armor[0].Defence;
            }
            foreach(var arm in unit.Armor)
            {

            }
            double averageDefence = Math.Round((unitDefence + armorDefence) / 2, 2);
            return averageDefence;
        }


        public double GetHitPower(Models.CharacterModel unit)
        {
            double result = unit.Weapon[0].AttackPower - CalculateWEaponFault(unit.Weapon[0]);
            // set average hit power
            double averageHitPower = Math.Round(unit.Attack + result, 2);
            return averageHitPower;
        }

        public double CalculateWEaponFault(WeaponModel weapon)
        {
            //calculate weapon fault 
            var random = new Random();
            double percent = random.NextDouble() * weapon.Fault;
            double result = (double)(weapon.AttackPower * percent / 100);
            return result;
        }

        public bool IsDefenderAlive(Models.CharacterModel defender, double HitPower)
        {
            return defender.Life - HitPower > 0 ? true : false;
        }
        public int WhoStartBattle()
        {
            return new Random().Next(0, 2);
        }
    }


}
