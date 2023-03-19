using Domain.GameCharacter;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public static class GameList
    {
        public static Character Player { get; set; }
        public static List<Character> EnemyList { get; set; } = new List<Character>();
        public static List<Character> FigterList { get; set; } = new List<Character>();
        public static List<WeaponModel> WeaponList { get; set; } = new List<WeaponModel>();
        public static List<ArmorModel> ArmorList { get; set; } = new List<ArmorModel> { };
        public static List<ShieldModel> ShieldList { get; set; } = new List<ShieldModel> { };

    }
}
