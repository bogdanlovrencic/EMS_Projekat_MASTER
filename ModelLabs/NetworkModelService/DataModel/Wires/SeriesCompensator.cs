using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class SeriesCompensator : ConductingEquipment
    {
        public SeriesCompensator(long globalId) : base(globalId)
        {
        }

        private float r;
        private float r0;
        private float x;
        private float x0;

        public float R
        {
            get { return r; }
            set { r = value; }
        }

        public float R0
        {
            get { return r0; }
            set { r0 = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float X0
        {
            get { return x0; }
            set { x0 = value; }
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                SeriesCompensator x = (SeriesCompensator)obj;
                return ((this.R == x.R) && this.R0 == x.R0 &&
                   this.X == x.X && this.X0 == x.X0);
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
        public override bool HasProperty(ModelCode property)
        {
            switch (property)
            {
                case ModelCode.SERCOMPENSATOR_R:
                case ModelCode.SERCOMPENSATOR_R0:
                case ModelCode.SERCOMPENSATOR_X:
                case ModelCode.SERCOMPENSATOR_X0:
                    return true;

                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SERCOMPENSATOR_R:
                    property.SetValue(R);
                    break;
                case ModelCode.SERCOMPENSATOR_R0:
                    property.SetValue(R0);
                    break;
                case ModelCode.SERCOMPENSATOR_X:
                    property.SetValue(X);
                    break;
                case ModelCode.SERCOMPENSATOR_X0:
                    property.SetValue(X0);
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
                case ModelCode.SERCOMPENSATOR_R:
                    R = property.AsFloat();
                    break;
                case ModelCode.SERCOMPENSATOR_R0:
                    R0 = property.AsFloat();
                    break;
                case ModelCode.SERCOMPENSATOR_X:
                    X = property.AsFloat();
                    break;
                case ModelCode.SERCOMPENSATOR_X0:
                    X0 = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }


        #endregion IAccess implementation

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
