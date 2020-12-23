using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{


    /// Analog represents an analog Measurement.
    public class Analog : Measurement
    {
        private float maxValue;
        private float minValue;
        private float normalValue;

        public Analog(long globalId) : base(globalId)
        {
        }

        public float MaxValue { get => maxValue; set => maxValue = value; }
        public float MinValue { get => minValue; set => minValue = value; }
        public float NormalValue { get => normalValue; set => normalValue = value; }
    }
}
