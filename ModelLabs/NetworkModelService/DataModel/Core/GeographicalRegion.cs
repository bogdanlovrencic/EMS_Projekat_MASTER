using System;
using System.Collections.Generic;
using FTN;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    /// A geographical region of a power system network model.
    public class GeographicalRegion : IdentifiedObject
    {
        private List<long> rotatingMachines = new List<long>();

        public GeographicalRegion(long globalId) : base(globalId)
        {
        }

        public override IdentifiedObject CloneEntity()
        {
            return new GeographicalRegion(GlobalId)
            {
                AliasName = this.AliasName,
                Mrid = this.Mrid,
                Name = this.Name,
                RotatingMachines = this.RotatingMachines
            };
        }

        public List<long> RotatingMachines { get => rotatingMachines; set => rotatingMachines = value; }
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                GeographicalRegion x = (GeographicalRegion)obj;
                return (CompareHelper.CompareLists(x.rotatingMachines, this.rotatingMachines));
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
                case ModelCode.GEOGRAPHICALREGION_ROTATINGMACHINES:
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.GEOGRAPHICALREGION_ROTATINGMACHINES:
                    prop.SetValue(rotatingMachines);
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

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #region IReference implementation
        public override bool IsReferenced
        {
            get
            {
                return rotatingMachines.Count != 0 || base.IsReferenced;
            }
        }

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {

            if (rotatingMachines != null && rotatingMachines.Count != 0 && (refType == TypeOfReference.Target || refType == TypeOfReference.Both))
            {
                references[ModelCode.GEOGRAPHICALREGION_ROTATINGMACHINES] = rotatingMachines.GetRange(0, rotatingMachines.Count);
            }

            base.GetReferences(references, refType);
        }

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION:
                    rotatingMachines.Add(globalId);
                    break;

                default:
                    base.AddReference(referenceId, globalId);
                    break;
            }
        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            switch (referenceId)
            {
                case ModelCode.ROTATINGMACHINE_GEOGRAPHICALREGION:

                    if (rotatingMachines.Contains(globalId))
                    {
                        rotatingMachines.Remove(globalId);
                    }
                    else
                    {
                        CommonTrace.WriteTrace(CommonTrace.TraceWarning, "Entity (GID = 0x{0:x16}) doesn't contain reference 0x{1:x16}.", this.GlobalId, globalId);
                    }

                    break;

                default:
                    base.RemoveReference(referenceId, globalId);
                    break;
            }
        }
        #endregion IReference implementation
    }
}
