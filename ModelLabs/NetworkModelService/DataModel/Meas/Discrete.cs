using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    /// Discrete represents a discrete Measurement, i.e. a Measurement reprsenting discrete values, e.g. a Breaker position.
    public class Discrete : Measurement
    {
        private int maxValue;
        private int minValue;
        private int normalValue;

        public Discrete(long globalId) : base(globalId)
        {
        }

        public int MaxValue { get => maxValue; set => maxValue = value; }
        public int MinValue { get => minValue; set => minValue = value; }
        public int NormalValue { get => normalValue; set => normalValue = value; }
    }
}
