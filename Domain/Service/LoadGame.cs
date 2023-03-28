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
        public void LoadFight(string userName)
        {
            LoadPlayer(userName);
            GetEnemy();
        }

        public void LoadPlayer(string userName)
        {
            var loadGame = new SaveAndLoadGame();
            loadGame.Load(userName);
        }

        private void GetEnemy()
        {
            var loadEnemy = new CreateEnemy();
            loadEnemy.CreateEnemye();
        }
    }
}
