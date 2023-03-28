using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.BattleModels
{
    public class HitResult
    {
        public string Atacker { get; set; }
        public string Defender { get; set; }
        public double AtackPower { get; set; }
        public double DefencePower { get; set;}
        public string AtackZone { get; set; }
        public string DefenceShieldZone { get; set; }
        public double DecreaseLife { get; set; }
        public double PlayerLife { get; set; }
        public double EnemyLife { get; set; }
    }
}
