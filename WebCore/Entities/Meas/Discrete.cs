using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities.Meas
{
    public class Discrete : Measurement
    {
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int NormalValue { get; set; }
    }
}
