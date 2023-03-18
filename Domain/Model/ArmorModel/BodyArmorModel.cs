using Domain.Model.HitPointModel;

namespace Domain.Models.ArmorModels
{
    public class BodyArmorModel : ArmorModel
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string? Name { get => base.Name; set => base.Name = value; }
        public override int Price { get => base.Price; set => base.Price = value; }
        public override string? ImageAddress { get => base.ImageAddress; set => base.ImageAddress = value; }
        public override double Defence { get => base.Defence; set => base.Defence = value; }
        public override double Penetration { get => base.Penetration; set => base.Penetration = value; }
        public override double Luck { get => base.Luck; set => base.Luck = value; }
        public override ZoneModel Zone { get => base.Zone; set => base.Zone = value; }

        public BodyArmorModel(int id, string? name, int price, string? imageAddress, double defence, double penetration, double luck, ZoneModel zone)
        {
            Id = id;
            Name = name;
            Price = price;
            ImageAddress = imageAddress;
            Defence = defence;
            Penetration = penetration;
            Luck = luck;
            Zone = zone;
        }
    }
}
