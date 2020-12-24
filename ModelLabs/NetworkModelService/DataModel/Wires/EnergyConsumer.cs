using System;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{



    /// Generic user of energy - a  point of consumption on the power system model.
    public class EnergyConsumer : ConductingEquipment
    {
        private float pfixed;
        private float qfixed;
        public EnergyConsumer(long globalId) : base(globalId)
        {
        }

        public float Pfixed { get => pfixed; set => pfixed = value; }
        public float Qfixed { get => qfixed; set => qfixed = value; }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                EnergyConsumer x = (EnergyConsumer)obj;
                return (x.pfixed == this.Pfixed && x.qfixed == this.Qfixed);
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
                case ModelCode.ENERGYCONSUMER_PFIXED:
                case ModelCode.ENERGYCONSUMER_QFIXED:
            
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.ENERGYCONSUMER_PFIXED:
                    prop.SetValue(pfixed);
                    break;
                case ModelCode.ENERGYCONSUMER_QFIXED:
                    prop.SetValue(qfixed);
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
                case ModelCode.ENERGYCONSUMER_PFIXED:
                    pfixed = property.AsFloat();
                    break;
                case ModelCode.ENERGYCONSUMER_QFIXED:
                    qfixed = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
    }
}
