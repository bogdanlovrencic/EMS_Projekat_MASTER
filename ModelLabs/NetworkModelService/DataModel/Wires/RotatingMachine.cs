using System;
using System.Collections.Generic;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{

    public class RotatingMachine : RegulatingCondEq
    {
        private float ratedS;
        private long geographicalRegion;
        public RotatingMachine(long globalId) : base(globalId)
        {
        }

        public override IdentifiedObject CloneEntity()
        {
            return new RotatingMachine(GlobalId)
            {
                Measurements = this.Measurements,
                AliasName = this.AliasName,
                EquipmentContainer = this.EquipmentContainer,
                GeographicalRegion = this.GeographicalRegion,
                Mrid = this.Mrid,
                Name = this.Name,
                RatedS = this.RatedS
            };
        }

        public float RatedS { get => ratedS; set => ratedS = value; }
        public long GeographicalRegion { get => geographicalRegion; set => geographicalRegion = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                RotatingMachine x = (RotatingMachine)obj;
                return (x.ratedS == this.RatedS && x.geographicalRegion == this.GeographicalRegion);
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


        public override bool HasProperty(ModelCode t)
        {
            switch (t)
            {
                case ModelCode.ROTATINGMACHINE_RATEDS:
                case ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION:
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.ROTATINGMACHINE_RATEDS:
                    prop.SetValue(ratedS);
                    break;
                case ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION:
                    prop.SetValue(geographicalRegion);
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
                case ModelCode.ROTATINGMACHINE_RATEDS:
                    ratedS = property.AsFloat();
                    break;
                case ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION:
                    ratedS = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (geographicalRegion != 0 && (refType == TypeOfReference.Reference || refType == TypeOfReference.Both))
            {
                references[ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION] = new List<long>();
                references[ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION].Add(geographicalRegion);
            }

            base.GetReferences(references, refType);
        }
    }
}
