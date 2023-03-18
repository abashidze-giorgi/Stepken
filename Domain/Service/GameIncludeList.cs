using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public static class GameIncludeList
    {
        public static List<CharacterModel> UnitList { get; set; } = new List<CharacterModel>();
    }
}
