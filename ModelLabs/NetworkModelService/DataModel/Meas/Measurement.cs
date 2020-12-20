using System;
using FTN;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    public class Measurement : IdentifiedObject
    {
        public Measurement(long globalId) : base(globalId)
        {
        }
    }
}
