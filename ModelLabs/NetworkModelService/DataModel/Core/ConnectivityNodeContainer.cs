using System;
using FTN;
using FTN.Common;


namespace FTN.Services.NetworkModelService.DataModel.Core
{

    public class ConnectivityNodeContainer : PowerSystemResource
    {
        public ConnectivityNodeContainer(long globalId) : base(globalId)
        {
        }

        public override IdentifiedObject CloneEntity()
        {
            return new ConnectivityNodeContainer(GlobalId)
            {
                Measurements = this.Measurements,
                AliasName = this.AliasName,
                Mrid = this.Mrid,
                Name = this.Name,
            };
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                return true;
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

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {

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
    }
}
