using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class Conductor : ConductingEquipment
    {
        public Conductor(long globalId) : base(globalId)
        {
        }

        private float length;

        public float Length
        {
            get => length;
            set => length = value;
        }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Conductor x = (Conductor)obj;
                return (x.Length == this.Length);
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

        public override bool HasProperty(ModelCode property)
        {
            switch (property)
            {
                case ModelCode.CONDUCTOR_LENGTH:

                    return true;
                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.CONDUCTOR_LENGTH:
                    property.SetValue(length);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.CONDUCTOR_LENGTH:
                    length = property.AsFloat();
                    break;

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
                return base.IsReferenced;
            }
        }

       
        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {

            base.GetReferences(references, refType);
        }
        

        public override void AddReference(ModelCode referenceId, long globalId)
        {
            base.AddReference(referenceId, globalId);

        }

        public override void RemoveReference(ModelCode referenceId, long globalId)
        {
            base.RemoveReference(referenceId, globalId);
        }

        #endregion IReference implementation
    }
}
