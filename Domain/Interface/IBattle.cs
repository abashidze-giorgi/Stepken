using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Interface
{
    public interface IBattle
    {
        public int WhoStartBattle(); // get randomly 0 or 1 in stage start
        public double GetHitPower(CharacterModel atacker); // return demage power 
        public double CalculateWEaponFault(WeaponModel weapon); // возвращает количество промаха
        public double GetDefencePower(CharacterModel defender); // return defence power
        public double GetBattleResult(ZoneModel zone, double hitPower, double defencePower);
        public bool IsDefenderAlive(CharacterModel defender, double HitPower);
    }
}
