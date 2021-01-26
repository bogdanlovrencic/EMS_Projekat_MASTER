using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Core;

namespace WebApp.Entities.Wires
{
    public class EnergyConsumer : ConductingEquipment
    {
        private float Pfixed { get; set; }
        private float Qfixed { get; set; }
    }
}
