using System;
using System.Collections.Generic;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel
{
    public class Equipment : PowerSystemResource
    {
        private long equipmentContainer = 0;

        public Equipment(long globalId) : base(globalId)
        {
        }

        public long EquipmentContainer { get => equipmentContainer; set => equipmentContainer = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Equipment x = (Equipment)obj;
                return (x.equipmentContainer == this.equipmentContainer);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region IAccess implementation
        public override bool HasProperty(ModelCode t)
        {
            switch (t)
            {
                case ModelCode.EQUIPMENT_EQUIPMENTCONT:          
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {

                case ModelCode.EQUIPMENT_EQUIPMENTCONT:
                    prop.SetValue(equipmentContainer);
                    break;

                default:
                    base.GetProperty(prop);
                    break;

            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
             
                case ModelCode.EQUIPMENT_EQUIPMENTCONT:
                    equipmentContainer = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
        #endregion

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (equipmentContainer != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.EQUIPMENT_EQUIPMENTCONT] = new List<long>();
                references[ModelCode.EQUIPMENT_EQUIPMENTCONT].Add(equipmentContainer);
            }

            base.GetReferences(references, refType);
        }
    }
}
