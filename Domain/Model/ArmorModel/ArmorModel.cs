using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class ArmorModel : AmmunitionModel
    {
        public virtual double Defence { get; set; }
        public virtual double Penetration { get; set; } //определяет, насколько процентов может отказать защита.
        public virtual double Luck { get; set; } // удача 
        public virtual ZoneModel Zone { get; set; } // определяет, какую зону тела защищает
    }
}


