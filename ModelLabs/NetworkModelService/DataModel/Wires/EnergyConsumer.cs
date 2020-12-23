using System;
using FTN;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{



    /// Generic user of energy - a  point of consumption on the power system model.
    public class EnergyConsumer : ConductingEquipment
    {
        private float pfixed;
        private float qfixed;
        public EnergyConsumer(long globalId) : base(globalId)
        {
        }

        public float Pfixed { get => pfixed; set => pfixed = value; }
        public float Qfixed { get => qfixed; set => qfixed = value; }
    }
}
