using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    /// Discrete represents a discrete Measurement, i.e. a Measurement reprsenting discrete values, e.g. a Breaker position.
    public class Discrete : Measurement
    {
        public Discrete(long globalId) : base(globalId)
        {
        }
    }
}
