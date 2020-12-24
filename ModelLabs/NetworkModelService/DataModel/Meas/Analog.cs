using System;
using FTN;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{


    /// Analog represents an analog Measurement.
    public class Analog : Measurement
    {
        private float maxValue;
        private float minValue;
        private float normalValue;

        public Analog(long globalId) : base(globalId)
        {
        }

        public float MaxValue { get => maxValue; set => maxValue = value; }
        public float MinValue { get => minValue; set => minValue = value; }
        public float NormalValue { get => normalValue; set => normalValue = value; }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Analog x = (Analog)obj;
                return (x.minValue == this.MinValue && x.maxValue == this.maxValue && x.normalValue == this.NormalValue);
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
                case ModelCode.ANALOG_MAXVALUE:
                case ModelCode.ANALOG_MINVALUE:
                case ModelCode.ANALOG_NORMALVALUE:

                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.ANALOG_MAXVALUE:
                    prop.SetValue(maxValue);
                    break;
                case ModelCode.ANALOG_MINVALUE:
                    prop.SetValue(minValue);
                    break;
                case ModelCode.ANALOG_NORMALVALUE:
                    prop.SetValue(normalValue);
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
                case ModelCode.ANALOG_MAXVALUE:
                    maxValue = property.AsFloat();
                    break;
                case ModelCode.ANALOG_MINVALUE:
                    minValue = property.AsFloat();
                    break;
                case ModelCode.ANALOG_NORMALVALUE:
                    normalValue = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
    }
}
