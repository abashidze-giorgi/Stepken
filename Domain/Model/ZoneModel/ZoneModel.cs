﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.HitPointModel
{
    public class ZoneModel
    {
        public int ID { get; set; }
        public string Name { get; set;}
        public bool IsProtected { get; set; }
        public bool IsAttacked { get; set; }
    }
}