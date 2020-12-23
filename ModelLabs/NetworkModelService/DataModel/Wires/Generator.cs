using System;
using FTN;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{

    /// An electromechanical device that operates with shaft rotating synchronously with the network. It is a single machine operating either as a generator or synchronous condenser or pump.
    public class Generator : RotatingMachine
    {
        private GeneratorType generatorType;
        private float maxQ;
        private float minQ;

        public Generator(long globalId) : base(globalId)
        {
        }

        public GeneratorType GeneratorType { get => generatorType; set => generatorType = value; }
        public float MaxQ { get => maxQ; set => maxQ = value; }
        public float MinQ { get => minQ; set => minQ = value; }
    }
}
