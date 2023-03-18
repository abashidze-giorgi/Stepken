using Domain.Inventory.Weapon;
using Domain.Models;

namespace Domain.Service
{
    public class CreateAmmunition
    {
        public  void Create()
        {
            CreateWeapon();
            CreateArmor();
            CreateShield();
        }
        #region Weapon Create
        private  void CreateWeapon()
        {
            ShortSword();
            LongtSword();
            Halberd();
            ShortBow();
            LongBow();
            CrossBow();
        }
        private  int GetId()
        {
            return GameList.WeaponList.Count() + 1;
        }
        private  void ShortSword()
        {
            var shortSword = new Weapon(GetId(), "Short Sword", 0, 8, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortSword.jpg");
            GameList.WeaponList.Add(shortSword);
        }
        private  void LongtSword()
        {
            var longtSword = new Weapon(GetId(), "Long sword", 45, 16, 50, $"{GetFolderPath.GetWeaponFolderPath()}\\LongSword.jpg");
            GameList.WeaponList.Add(longtSword);
        }
        private  void Halberd()
        {
            var alebard = new Weapon(GetId(), "Alebard", 52, 24, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\Alebard.jpg");
            GameList.WeaponList.Add(alebard);
        }
        private  void CrossBow()
        {
            var crossBow = new Weapon(GetId(), "CrossBow", 98, 35, 58, $"{GetFolderPath.GetWeaponFolderPath()}\\CrossBow.jpg");
            GameList.WeaponList.Add(crossBow);
        }
        private  void LongBow()
        {
            var longBow = new Weapon(GetId(), "LongBow", 70, 30, 60, $"{GetFolderPath.GetWeaponFolderPath()}\\LongBow.jpg");
            GameList.WeaponList.Add(longBow);
        }
        private  void ShortBow()
        {
            var shortBow = new Weapon(GetId(), "ShortBow", 64, 30, 75, $"{GetFolderPath.GetWeaponFolderPath()}\\ShortBow.png");
            GameList.WeaponList.Add(shortBow);
        }
        #endregion

        #region Armor Create
        private void CreateArmor()
        {

        }
        #endregion

        #region Shiel Create
        private void CreateShield()
        {

        }
        #endregion
    }
}
