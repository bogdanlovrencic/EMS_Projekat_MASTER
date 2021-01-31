using System;
using System.Collections.Generic;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    public class Measurement : IdentifiedObject
    {
        private Direction directionMethod;
        private MeasurementType measurementType;
        private string saveAddress;
        private long powerSysResource = 0;

        
        public Measurement(long globalId) : base(globalId)
        {

        }

        public override IdentifiedObject CloneEntity()
        {
            return new Measurement(GlobalId)
            {
                MeasurementType = this.MeasurementType,
                Mrid = this.Mrid,
                Name = this.Name,
                AliasName = this.AliasName,
                PowerSysResource = this.PowerSysResource,
                DirectionMethod = this.DirectionMethod,
                SaveAdress = this.SaveAdress,
            };
        }

        public Direction DirectionMethod { get => directionMethod; set => directionMethod = value; }
        public MeasurementType MeasurementType { get => measurementType; set => measurementType = value; }
        public string SaveAdress { get => saveAddress; set => saveAddress = value; }
        public long PowerSysResource { get => powerSysResource; set => powerSysResource = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Measurement x = (Measurement)obj;
                return (x.directionMethod == this.directionMethod && x.measurementType == this.measurementType && x.saveAddress == this.saveAddress && x.powerSysResource == this.powerSysResource);
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
                case ModelCode.MEASUREMENT_DIRECTIONMETHOD:
                case ModelCode.MEASUREMENT_MEASUREMENTTYPE:
                case ModelCode.MEASUREMENT_SAVEADRESS:
                case ModelCode.MEASUREMENT_POWERSYSRES:
               
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.MEASUREMENT_DIRECTIONMETHOD:
                    prop.SetValue((short)directionMethod);
                    break;
                case ModelCode.MEASUREMENT_MEASUREMENTTYPE:
                    prop.SetValue((short)measurementType);
                    break;
                case ModelCode.MEASUREMENT_SAVEADRESS:
                    prop.SetValue(saveAddress);
                    break;
                case ModelCode.MEASUREMENT_POWERSYSRES:
                    prop.SetValue(powerSysResource);
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
                case ModelCode.MEASUREMENT_DIRECTIONMETHOD:
                    directionMethod = (Direction)property.AsEnum();
                    break;
                case ModelCode.MEASUREMENT_MEASUREMENTTYPE:
                    measurementType = (MeasurementType)property.AsEnum();
                    break;
                case ModelCode.MEASUREMENT_SAVEADRESS:
                    saveAddress = property.AsString();
                    break;
                case ModelCode.MEASUREMENT_POWERSYSRES:
                    powerSysResource = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
        #endregion

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (powerSysResource != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.MEASUREMENT_POWERSYSRES] = new List<long>();
                references[ModelCode.MEASUREMENT_POWERSYSRES].Add(powerSysResource);
            }

            base.GetReferences(references, refType);
        }
    }
}
