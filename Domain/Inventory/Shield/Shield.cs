using Domain.Models;
using Domain.Model.HitPointModel;

namespace Domain.Inventory.Shield
{
    public class Shield : ShieldModel
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string? Name { get => base.Name; set => base.Name = value; }
        public override int Price { get => base.Price; set => base.Price = value; }
        public override string? ImageAddress { get => base.ImageAddress; set => base.ImageAddress = value; }
        public override double Defence { get => base.Defence; set => base.Defence = value; }
        public override double BlockChance { get => base.BlockChance; set => base.BlockChance = value; }
        public override double AttackPenalty { get => base.AttackPenalty; set => base.AttackPenalty = value; }
        public override List<ZoneModel> Zone { get => base.Zone; set => base.Zone = value; }

        public Shield(int id, string? name, int price, string? imageAddress, double defence, double blockChance, double attackPenalty, List<ZoneModel> zone)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageAddress = imageAddress;
            Defence = defence;
            BlockChance = blockChance;
            AttackPenalty = attackPenalty;
            Zone = zone;
        }
    }
}
