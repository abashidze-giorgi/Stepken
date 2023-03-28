using Domain.GameCharacter;
using Domain.Model.BattleModels;
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
        public static Character? Player { get; set; }
        public static Character? Enemy { get; set; }
        public static int battleRound = 1;
        public static HitResult hitResult { get; set; } = new HitResult();

    }
}
