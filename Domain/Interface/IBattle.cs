﻿using Domain.Model.HitPointModel;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IBattle
    {
        public int WhoStartBattle(); // get randomly 0 or 1 in stage start
        public double GetHitPower(UnitModel atacker); // return demage power 
        public double GetDefencePower(UnitModel defender); // return defence power
        public double GetBattleResult(ZoneModel zone, double hitPower, double defencePower);
        public bool IsDefenderAlive(UnitModel defender, double HitPower);
    }
}
