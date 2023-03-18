using Domain.Character;
using Domain.Inventory.Shield;
using Domain.Model.Character;
using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Service
{
    public static class CreateEnemyList
    {
        public static List<CharacterModel> EnemyList { get; set; } = new List<CharacterModel>();
        private static int GetUnitId()
        {
            return EnemyList.Count + 1;
        }
        public static void CreateEnemyes()
        {
            CreateGoblin();
        }
        private static void CreateGoblin()
        {
            var goblin = new Enemy(
                GetUnitId(), "Goblin", 450, 17, 16, CharacterRaceEnum.Goblin, EnemyLevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Goblin.jpg");
            EnemyList.Add(goblin);
        }


        private static void CreateKobold()
        {
            var kobold = new Enemy(3, "Kobold", 320, 14, 17, CharacterRaceEnum.Kobold, EnemyLevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Kobold.jpg");
            EnemyList.Add(kobold);
        }

        private static void CreateOrc()
        {
            var orc = new Enemy(
                GetUnitId(), "Orc", 640, 32, 24, CharacterRaceEnum.Orc, EnemyLevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Orc.jpg");
            EnemyList.Add(orc);
        }
    }
}
