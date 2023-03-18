using Domain.GameCharacter;
using Domain.Model.HitPointModel;
using Domain.Models;

namespace Domain.Interface
{
    public interface IBattle
    {
        public void StartBattle(Character player, Character enemy, ZoneModel zone);
        public void SetAtacker(); // get randomly 0 or 1 in stage start
        public double GetHitPower(Character atacker); // return demage power 
        public double CalculateWEaponFault(WeaponModel weapon); // возвращает количество промаха
        public double GetDefencePower(Character defender, ZoneModel zone); // return defence power
        public double GetBattleResult(double hitPower, double defencePower, ZoneModel zone);
        public bool IsDefenderAlive(Character defender, double HitPower);
    }
}
