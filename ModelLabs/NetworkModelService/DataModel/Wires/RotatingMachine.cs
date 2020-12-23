using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{

    public class RotatingMachine : RegulatingCondEq
    {
        private float apparentPower; 
        public RotatingMachine(long globalId) : base(globalId)
        {
        }

        public float ApparentPower { get => apparentPower; set => apparentPower = value; }
    }
}
