using System;
using FTN;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
   


    /// A geographical region of a power system network model.
    public class GeographicalRegion : IdentifiedObject
    {
        public GeographicalRegion(long globalId) : base(globalId)
        {
        }
    }
}
