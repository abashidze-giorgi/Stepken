using Domain.GameCharacter;
using Domain.Inventory.Shield;
using Domain.Inventory.Weapon;
using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Service
{
    public class CreatePlayer
    {
        public void Player() 
        {
            var player = new Character(GetId(), "Human", 350, 40, 40,
                CharacterRaceEnum.Human, Model.Character.LevelModel.Level_1,                
                $"{GetFolderPath.GetCharacterFolderPath()}\\human.jpg");
            player.Weapon.Add(GameList.WeaponList[0]);
            GameList.UnitList.Add(player);
        }
        private static int GetId()
        {
            return GameList.UnitList.Count + 1;
        }
    }
}
