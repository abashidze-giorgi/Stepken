using Domain.GameCharacter;
using Domain.Interface;
using Domain.Model.HitPointModel;
using Domain.Models;
using System;

namespace Domain.Service
{
    public class Battle : IBattle
    {
        public int atacker { get; set; } = 0;
        private int defender = 1;
        public void StartBattle(ZoneModel zone)
        {

            var hitPower = GetHitPower(GameList.FigterList[atacker]);
            var defencePower = GetDefencePower(GameList.FigterList[defender], zone);
            var lifeDecrease = GetBattleResult(hitPower, defencePower, zone);
            
            var isDefenderAlive = IsDefenderAlive(GameList.FigterList[defender], lifeDecrease);
            if(isDefenderAlive)
            {
                GameList.FigterList[defender].Life = Math.Round(GameList.FigterList[defender].Life - lifeDecrease, 2);
            }
            else
            {
                GameList.FigterList[defender].Life = 0;
                GameList.FigterList.Clear();
            }
            ChageAtacker();
        }

     
        public double GetBattleResult(double hitPower, double defencePower, ZoneModel zone)
        {
            double zonePenalt = GetZonePenalte(zone);
            double result = hitPower - zonePenalt * defencePower;
            return result;
        }

        private double GetZonePenalte(ZoneModel zone)
        {
            double HeadPenalt = 0.7;
            double bodyPenalt = 0.5;
            double legPenalt = 0.2;
            double zonePenalt = 0.5;
            foreach(var sh in GameList.FigterList[defender].Shield.Zone)
            {
                if(sh == zone)
                {
                    zonePenalt = 1.1;
                }
            }
           
            switch(zone)
            {
                case ZoneModel.Head:
                    zonePenalt = HeadPenalt;
                    break;

                case ZoneModel.Body:
                    zonePenalt = bodyPenalt;
                    break; 

                case ZoneModel.Leg:
                    zonePenalt = legPenalt;
                    break;
            }
            return zonePenalt;
        }

        public double GetDefencePower(Character unit , ZoneModel zone)
        {
            double unitDefence = unit.Defence;
            double armorDefence = 0;
            foreach(var arm in unit.Armor)
            {
                if (unit.Armor[0].Zone == zone)
                {
                    armorDefence += unit.Armor[0].Defence;
                    break;
                }
            }
            
            double averageDefence = Math.Round((unitDefence + armorDefence) / 2, 2);
            return averageDefence;
        }

        public double GetHitPower(Character unit)
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

        public bool IsDefenderAlive(Character defender, double LifeDecrease)
        {
            return defender.Life - LifeDecrease > 0 ? true : false;
        }
        public void SetAtacker()
        {
            var random = new Random();

            if (random.NextInt64(0, 2) == 0)
            {
                atacker = 0; 
                defender = 1;
            }
            else
            {
                atacker = 1; 
                defender = 0;
            }
        }
        private void ChageAtacker()
        {
            var temp = atacker;
            atacker = defender;
            defender = temp;
        }

        public ZoneModel GetRandomAttackZone()
        {
            var random = new Random();
            int zoneIndex =(int) random.NextInt64(1, 4);
            var zone = ZoneModel.none;
            switch (zoneIndex)
            {
                case 1:
                    zone = ZoneModel.Head;
                    break;
                case 2:
                    zone = ZoneModel.Body;
                    break;
                case 3:
                    zone = ZoneModel.Leg;
                    break;
            }
            return zone;
        }
    }
}
