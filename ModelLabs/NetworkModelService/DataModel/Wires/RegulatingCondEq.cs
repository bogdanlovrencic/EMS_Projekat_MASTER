using System;
using FTN;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{



    /// A type of conducting equipment that can regulate a quanity (i.e. voltage or flow) at a specific point in the network.
    public class RegulatingCondEq : ConductingEquipment
    {
        public RegulatingCondEq(long globalId) : base(globalId)
        {
        }
    }
}
