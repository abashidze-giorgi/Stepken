using Domain.GameCharacter;
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
        
        private static int GetUnitId()
        {
            return GameIncludeList.UnitList.Count + 1;
        }
        public static void CreateEnemyes()
        {
            CreateGoblin();
            CreateKobold();
            CreateOrc();
        }
        private static void CreateGoblin()
        {
            var goblin = new Character(
                GetUnitId(), "Goblin", 450, 17, 16, CharacterRaceEnum.Goblin, LevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Goblin.jpg");
            GameIncludeList.UnitList.Add(goblin);
        }


        private static void CreateKobold()
        {
            var kobold = new Character(3, "Kobold", 320, 14, 17, CharacterRaceEnum.Kobold, LevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Kobold.jpg");
            GameIncludeList.UnitList.Add(kobold);
        }

        private static void CreateOrc()
        {
            var orc = new Character(
                GetUnitId(), "Orc", 640, 32, 24, CharacterRaceEnum.Orc, LevelModel.Level_1, $"{GetFolderPath.GetCharacterFolderPath()}\\Orc.jpg");
            GameIncludeList.UnitList.Add(orc);
        }
    }
}
