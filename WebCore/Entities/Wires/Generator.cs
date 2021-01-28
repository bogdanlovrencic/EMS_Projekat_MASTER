using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Enums;

namespace WebApp.Entities.Wires
{
    public class Generator : RotatingMachine
    {
        public GeneratorType GeneratorType { get; set; }
        public float MaxQ { get; set; }
        public float MinQ { get; set; }
    }
}
