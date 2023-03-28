using Domain.Models;
using Domain.GameCharacter;
using Domain.Model.HitPointModel;

namespace Domain.Interface
{
    public interface IBattle
    {
        public void SetAtacker(); 
        public void StartBattle(ZoneModel zone);
        public double GetHitPower(Character atacker);
        public double CalculateWEaponFault(WeaponModel weapon); 
        public bool IsDefenderAlive(Character defender, double HitPower);
        public double GetDefencePower(Character defender, ZoneModel zone); 
        public double GetBattleResult(double hitPower, double defencePower, ZoneModel zone);
    }
}
