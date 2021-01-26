using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Core;
using WebApp.Entities.Enums;

namespace WebApp.Entities.Meas
{
    public class Measurement : IdentifiedObject
    {
        public Direction DirectionMethod { get; set; }
        public MeasurementType MeasurementType { get; set; }
        public string SaveAdress { get; set; }
        public long PowerSysResource = 0;
    }
}
