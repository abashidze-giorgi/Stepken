using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class LoadGameEnvironment
    {
        public void LoadGame()
        {
            CreateAmunition();
            CreateEnemy();
        }

        private void CreateAmunition()
        {
            var ca = new CreateAmmunition();
            ca.Create();
        }

        private void CreateEnemy()
        {
            var ce = new  CreateEnemy();
            ce.CreateEnemyes();
        }
    }
}
