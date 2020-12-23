using System;
using FTN;
using System.Collections.Generic;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel
{
    /// A modeling construct to provide a root class for containing equipment.
    public class EquipmentContainer : ConnectivityNodeContainer
    {
        private List<Equipment> Equipments;
        public EquipmentContainer(long globalId) : base(globalId)
        {
        }
    }
}
