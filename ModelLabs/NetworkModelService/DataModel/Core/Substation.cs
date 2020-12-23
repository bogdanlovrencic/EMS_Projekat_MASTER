using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Core
{

    /// A collection of equipment for purposes other than generation or utilization, through which electric energy in bulk is passed for the purposes of switching or modifying its characteristics.
    public class Substation : EquipmentContainer
    {
        public Substation(long globalId) : base(globalId)
        {
        }
    }
}
