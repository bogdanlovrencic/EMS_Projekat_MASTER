using System;
using FTN;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{

    public class RotatingMachine : RegulatingCondEq
    {
        private float ratedS; 
        public RotatingMachine(long globalId) : base(globalId)
        {
        }

        public float RatedS { get => ratedS; set => ratedS = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                RotatingMachine x = (RotatingMachine)obj;
                return (x.ratedS == this.RatedS);
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
              
                default:
                    base.SetProperty(property);
                    break;
            }
        }
    }
}
