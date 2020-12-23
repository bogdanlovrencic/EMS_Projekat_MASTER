using System;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    public class Measurement : IdentifiedObject
    {
        private Direction directionMethod;
        private MeasurementType measurementType;
        private string saveAdress;
        public Measurement(long globalId) : base(globalId)
        {
        }

        public Direction DirectionMethod { get => directionMethod; set => directionMethod = value; }
        public MeasurementType MeasurementType { get => measurementType; set => measurementType = value; }
        public string SaveAdress { get => saveAdress; set => saveAdress = value; }
    }
}
