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

        public double GetDefencePower(UnitModel defender)
        {
            throw new NotImplementedException();
        }
        public double GetHitPower(UnitModel atacker)
        {
            double unitAtack = atacker.Attack;
            //calculate weapon attack by its fault value
            double weaponAttack = atacker.Weapon[0].AttackPower;
            double fault = atacker.Weapon[0].Fault;
            var random = new Random();
            double percent = random.NextDouble() * fault;
            double decrease = (double)(weaponAttack * percent / 100);
            double result = weaponAttack - decrease;
            // set average hit power
            double averageHitPower = Math.Round(unitAtack + result, 2);
            return averageHitPower;
        }
        public bool IsDefenderAlive(UnitModel defender, double HitPower)
        {
            return defender.Life - HitPower > 0 ? true : false;
        }
        public int WhoStartBattle()
        {
            return new Random().Next(0, 2);
        }
    }


}
