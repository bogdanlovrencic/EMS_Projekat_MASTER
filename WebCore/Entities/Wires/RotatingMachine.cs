using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities.Wires
{
    public class RotatingMachine : RegulatingCondEq
    {
        public float RatedS { get; set; }
    }
}
