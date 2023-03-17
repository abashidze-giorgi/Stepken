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
            double ZoneDefences = 0;
            foreach(var arm in unit.Armor)
            {

            }
            double averageDefence = Math.Round((unitDefence + armorDefence) / 2, 2);
            return averageDefence;
        }


        public double GetHitPower(CharacterModel unit)
        {
            double unitAtack = unit.Attack;
            //calculate weapon attack by its fault value
            double weaponAttack = unit.Weapon[0].AttackPower;
            double fault = unit.Weapon[0].Fault;
            var random = new Random();
            double percent = random.NextDouble() * fault;
            double decrease = (double)(weaponAttack * percent / 100);
            double result = weaponAttack - decrease;
            // set average hit power
            double averageHitPower = Math.Round(unitAtack + result, 2);
            return averageHitPower;
        }
        public bool IsDefenderAlive(CharacterModel defender, double HitPower)
        {
            return defender.Life - HitPower > 0 ? true : false;
        }
        public int WhoStartBattle()
        {
            return new Random().Next(0, 2);
        }
    }


}
