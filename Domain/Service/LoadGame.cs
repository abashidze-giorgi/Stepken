using Domain.GameCharacter;
using Domain.Inventory.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class LoadGame
    {
        public void LoadGameUnits(int id = -1) 
        {
            GetEnemy(id);
            SetFigterList();
        }

        private void SetFigterList(int id = -1)
        {
            GameList.FigterList.Clear();
            GameList.FigterList.Add(GameList.Player);
            GameList.FigterList.Add(GetEnemy(id));
        }
        private Character GetEnemy(int id = -1)
        {
            if(id == -1)
            {
                id = GetRandomEnemyId();
            }
            var enemy = GameList.EnemyList[id];
            enemy.Weapon.Add(GameList.WeaponList[GetRandomWeaponId()]);
            return enemy;
        }
        private int GetRandomEnemyId()
        {
            var random = new Random();
            int result = (int)random.Next(0, GameList.EnemyList.Count);
            return result;
        }
        private int GetRandomWeaponId()
        {
            var random = new Random();
            int weaponId = (int)random.Next(0, GameList.WeaponList.Count);
            return weaponId;
        }
    }
}
