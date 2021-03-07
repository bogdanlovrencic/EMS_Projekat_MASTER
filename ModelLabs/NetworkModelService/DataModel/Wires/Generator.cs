using System;
using FTN;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{

    /// An electromechanical device that operates with shaft rotating synchronously with the network. It is a single machine operating either as a generator or synchronous condenser or pump.
    public class Generator : RotatingMachine
    {
        private GeneratorType generatorType;
        private float maxQ;
        private float minQ;

        public Generator(long globalId) : base(globalId)
        {
        }

        public override IdentifiedObject CloneEntity()
        {
            return new Generator(GlobalId)
            {
                Measurements = this.Measurements,
                GeographicalRegion = this.GeographicalRegion,
                AliasName = this.AliasName,
                EquipmentContainer = this.EquipmentContainer,
                Mrid = this.Mrid,
                Name = this.Name,
                RatedS = this.RatedS,
                GeneratorType = this.GeneratorType,
                MaxQ = this.MaxQ,
                MinQ = this.MinQ
            };
        }

        public GeneratorType GeneratorType { get => generatorType; set => generatorType = value; }
        public float MaxQ { get => maxQ; set => maxQ = value; }
        public float MinQ { get => minQ; set => minQ = value; }


        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Generator x = (Generator)obj;
                return (x.maxQ == this.MaxQ && x.minQ == this.MinQ && x.generatorType == this.GeneratorType);
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
                case ModelCode.GENERATOR_MAXQ:
                case ModelCode.GENERATOR_MINQ:
                case ModelCode.GENERATOR_GENERATORTYPE:

                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {
                case ModelCode.GENERATOR_MAXQ:
                    prop.SetValue(maxQ);
                    break;
                case ModelCode.GENERATOR_MINQ:
                    prop.SetValue(minQ);
                    break;
                case ModelCode.GENERATOR_GENERATORTYPE:
                    prop.SetValue((short)generatorType);
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
                case ModelCode.GENERATOR_MAXQ:
                    maxQ = property.AsFloat();
                    break;
                case ModelCode.GENERATOR_MINQ:
                    minQ = property.AsFloat();
                    break;
                case ModelCode.GENERATOR_GENERATORTYPE:
                    generatorType = (GeneratorType)property.AsEnum();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }
    }
}
