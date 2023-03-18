using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventory.Weapon
{
    public class Weapon : WeaponModel
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string? Name { get => base.Name; set => base.Name = value; }
        public override int Price { get => base.Price; set => base.Price = value; }
        public override string? ImageAddress { get => base.ImageAddress; set => base.ImageAddress = value; }
        public override double AttackPower { get => base.AttackPower; set => base.AttackPower = value; }
        public override double Fault { get => base.Fault; set => base.Fault = value; }

        public Weapon(int id, string? name, int price, double attackPower, double fault, string? imageAddress)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageAddress = imageAddress;
            AttackPower = attackPower;
            Fault = fault;
        }
    }
}
