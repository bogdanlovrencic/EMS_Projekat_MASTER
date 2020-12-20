using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class ACLineSegment : Conductor
    {
        public ACLineSegment(long globalId) : base(globalId)
        {
        }

        private float b0ch;
        private float bch;
        private float g0ch;
        private float gch;
        private float r;
        private float r0;
        private float x;
        private float x0;

        public float X0
        {
            get { return x0; }
            set { x0 = value; }
        }


        public float X
        {
            get { return x; }
            set { x = value; }
        }


        public float R0
        {
            get { return r0; }
            set { r0 = value; }
        }


        public float R
        {
            get { return r; }
            set { r = value; }
        }


        public float Gch
        {
            get { return gch; }
            set { gch = value; }
        }


        public float G0ch
        {
            get { return g0ch; }
            set { g0ch = value; }
        }


        public float Bch
        {
            get { return bch; }
            set { bch = value; }
        }


        public float B0ch
        {
            get { return b0ch; }
            set { b0ch = value; }
        }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                ACLineSegment x = (ACLineSegment)obj;
                return (x.B0ch == this.B0ch && x.Bch == this.Bch &&
                    x.G0ch == this.G0ch && x.Gch == this.Gch &&
                    x.R == this.R && x.R0 == this.R0 &&
                    x.X == this.X && x.X0 == this.X0);
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
                case ModelCode.ACLINESEG_B0CH:
                case ModelCode.ACLINESEG_BCH:
                case ModelCode.ACLINESEG_G0CH:
                case ModelCode.ACLINESEG_GCH:
                case ModelCode.ACLINESEG_X:
                case ModelCode.ACLINESEG_X0:
                case ModelCode.ACLINESEG_R:
                case ModelCode.ACLINESEG_R0:

                    return true;
                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.ACLINESEG_B0CH:
                    property.SetValue(B0ch);
                    break;
                case ModelCode.ACLINESEG_BCH:
                    property.SetValue(Bch);
                    break;
                case ModelCode.ACLINESEG_G0CH:
                    property.SetValue(G0ch);
                    break;
                case ModelCode.ACLINESEG_GCH:
                    property.SetValue(Gch);
                    break;
                case ModelCode.ACLINESEG_X:
                    property.SetValue(X);
                    break;
                case ModelCode.ACLINESEG_X0:
                    property.SetValue(X0);
                    break;
                case ModelCode.ACLINESEG_R:
                    property.SetValue(R);
                    break;
                case ModelCode.ACLINESEG_R0:
                    property.SetValue(R0);
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
                case ModelCode.ACLINESEG_B0CH:
                    B0ch = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_BCH:
                    Bch = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_G0CH:
                    G0ch = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_GCH:
                    Gch = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_X:
                    X = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_X0:
                    X0 = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_R:
                    R = property.AsFloat();
                    break;
                case ModelCode.ACLINESEG_R0:
                    R0 = property.AsFloat();
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
