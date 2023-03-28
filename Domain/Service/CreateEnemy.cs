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
    public class CreateEnemy
    {
        
        public void CreateEnemye()
        {
            switch (GameList.battleRound)
            {
                case 1:
                    CreateGoblin();
                    break;
                case 2:
                    CreateKobold();
                    break;
                case 3:
                    CreateOrc();
                    break;
                case 4:
                    CreateCyclop();
                    break;
            }
        }
        private void CreateGoblin()
        {
            var folderPath = GetFolderPath.GetCharacterFolderPath();
            var imagePath = Path.Combine(folderPath, "Goblin.jpg");
            var goblin = new Character(
                1, "Goblin", 350, 350, 15, 15, CharacterRaceEnum.Goblin, LevelModel.Level_1, imagePath);
            goblin.Shield = (ShieldModel) CreateAmmunition.CreateShield(RandomShieldId());
            goblin.Weapon.Add((WeaponModel)CreateAmmunition.CreateWeapon(1));
            GameList.Enemy = goblin;
        }
        private void CreateKobold()
        {
            var folderPath = GetFolderPath.GetCharacterFolderPath();
            var imagePath = Path.Combine(folderPath, "Kobold.jpg");
            var kobold = new Character(
                2, "Kobold", 400, 400, 20, 16, CharacterRaceEnum.Kobold, LevelModel.Level_1, imagePath);
            kobold.Shield = (ShieldModel)CreateAmmunition.CreateShield(RandomShieldId());
            kobold.Weapon.Add((WeaponModel)CreateAmmunition.CreateWeapon(1));
            GameList.Enemy = kobold;
        }
        private void CreateOrc()
        {
            var folderPath = GetFolderPath.GetCharacterFolderPath();
            var imagePath = Path.Combine(folderPath, "Orc.jpg");
            var orc = new Character(
                3, "Orc", 420, 420, 22, 26, CharacterRaceEnum.Orc, LevelModel.Level_1, imagePath);
            orc.Shield = (ShieldModel)CreateAmmunition.CreateShield(RandomShieldId());
            orc.Weapon.Add((WeaponModel)CreateAmmunition.CreateWeapon(1));


            GameList.Enemy = orc;
        }

        private void CreateCyclop()
        {
            var folderPath = GetFolderPath.GetCharacterFolderPath();
            var imagePath = Path.Combine(folderPath, "Cyclop.jpg");
            var cyclop = new Character(
                4, "Cyclop", 500, 500, 34, 75, CharacterRaceEnum.Orc, LevelModel.Level_1, imagePath);
            cyclop.Shield = (ShieldModel)CreateAmmunition.CreateShield(RandomShieldId());
            cyclop.Weapon.Add((WeaponModel)CreateAmmunition.CreateWeapon(1));
            GameList.Enemy = cyclop;
        }

        private int RandomShieldId()
        {
            var random = new Random();
            return random.Next(1, 6);
        }
    }
}
