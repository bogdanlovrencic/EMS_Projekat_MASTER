using System;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Meas
{

    /// Discrete represents a discrete Measurement, i.e. a Measurement reprsenting discrete values, e.g. a Breaker position.
    public class Discrete : Measurement
    {
        private int maxValue;
        private int minValue;
        private int normalValue;

        public Discrete(long globalId) : base(globalId)
        {
        }

        public int MaxValue { get => maxValue; set => maxValue = value; }
        public int MinValue { get => minValue; set => minValue = value; }
        public int NormalValue { get => normalValue; set => normalValue = value; }

        public override IdentifiedObject CloneEntity()
        {
            return new Discrete(GlobalId)
            {
                MaxValue = this.MaxValue,
                MeasurementType = this.MeasurementType,
                MinValue = this.MinValue,
                Mrid = this.Mrid,
                Name = this.Name,
                AliasName = this.AliasName,
                NormalValue = this.NormalValue,
                PowerSysResource = this.PowerSysResource,
                DirectionMethod = this.DirectionMethod,
                SaveAdress = this.SaveAdress,
            };
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Discrete x = (Discrete)obj;
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
                case ModelCode.DISCRETE_MAXVALUE:
                case ModelCode.DISCRETE_MINVALUE:
                case ModelCode.DISCRETE_NORMALVALUE:

                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.DISCRETE_MAXVALUE:
                    prop.SetValue(maxValue);
                    break;
                case ModelCode.DISCRETE_MINVALUE:
                    prop.SetValue(minValue);
                    break;
                case ModelCode.DISCRETE_NORMALVALUE:
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
                case ModelCode.DISCRETE_MAXVALUE:
                    maxValue = property.AsInt();
                    break;
                case ModelCode.DISCRETE_MINVALUE:
                    minValue = property.AsInt();
                    break;
                case ModelCode.DISCRETE_NORMALVALUE:
                    normalValue = property.AsInt();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
    }
}
