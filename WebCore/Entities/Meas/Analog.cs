using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities.Meas
{
    public class Analog : Measurement
    {
        public float MaxValue { get; set; }
        public float MinValue { get; set; }
        public float NormalValue { get; set; }
    }
}
