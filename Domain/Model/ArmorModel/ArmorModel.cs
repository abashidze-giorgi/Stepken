using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class ArmorModel : AmmunitionModel
    {
        public double Defence { get; set; }
        public double Penetration { get; set; } //определяет, насколько процентов может отказать защита.
        public double Luck { get; set; } // удача 
        public List<ZoneModel> Zone { get; set; } = new List<ZoneModel>(); // определяет, какую зону тела защищает
    }
}


