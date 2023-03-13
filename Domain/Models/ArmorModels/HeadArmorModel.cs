using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.ArmorModels
{
    public class HeadArmorModel : ArmorModel
    {
        public double VisibilityPenalty { get; set; } // насколько щит влияет на видимость юнита
    }
}
