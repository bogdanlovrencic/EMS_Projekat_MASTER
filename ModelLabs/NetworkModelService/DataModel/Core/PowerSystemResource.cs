using System;
using FTN;
using System.Collections.Generic;
using FTN.Services.NetworkModelService.DataModel.Meas;

namespace FTN.Services.NetworkModelService.DataModel.Core
{

    /// A power system resource can be an item of equipment such as a switch, an equipment container containing many individual items of equipment such as a substation, or an organisational entity such as sub-control area. Power system resources can have measurements associated.
    public class PowerSystemResource : IdentifiedObject
    {
        private List<Measurement> Measurements;
        public PowerSystemResource(long globalId) : base(globalId)
        {
        }


    }
}
