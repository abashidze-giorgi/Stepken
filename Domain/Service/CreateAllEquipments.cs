using Domain.Interface;
using Domain.Inventory.Weapons;
using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class CreateAllEquipments
    {
        public List<AmmunitionModel> AmmunitionGlobalList = new List<AmmunitionModel>();

        public void CreateWeapons()
        {

            AmmunitionGlobalList.Add(ShortSword());
            AmmunitionGlobalList.Add(LongtSword());
            AmmunitionGlobalList.Add(Halberd());
            AmmunitionGlobalList.Add(CrossBow());
            AmmunitionGlobalList.Add(LongBow());
            AmmunitionGlobalList.Add(ShortBow());
        }

        private ShortSword ShortSword()
        {
            var shortSword = new ShortSword
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Short Sword",
                Price = 0
            };
            return shortSword;
        }
        private LongSword LongtSword()
        {
            var longtSword = new LongSword
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Long Sword",
                Price = 0
            };
            return longtSword;
        }
        private Alebard Halberd()
        {
            var alebard = new Alebard
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "Alebard",
                Price = 0
            };
            return alebard;
        }
        private CrossBow CrossBow()
        {
            var crossBow = new CrossBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "CrossBow",
                Price = 0
            };
            return crossBow;
        }
        private LongBow LongBow()
        {
            var longBow = new LongBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "LongBow",
                Price = 0
            };
            return longBow;
        }
        private ShortBow ShortBow()
        {
            var shortBow = new ShortBow
            {
                Accuracy = 0,
                AttackPower = 0,
                Id = 0,
                Name = "ShortBow",
                Price = 0
            };
            return shortBow;
        }
    }
}
