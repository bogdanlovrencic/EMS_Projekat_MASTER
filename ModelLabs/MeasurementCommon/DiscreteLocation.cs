using FTN.Services.NetworkModelService.DataModel.Meas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementCommon
{
    public class DiscreteLocation : ICloneable
    {
        public DiscreteLocation()
        {

        }
		public Discrete Discrete { get; set; }

		public int StartAddress { get; set; }

		public int Length { get; set; }

		public int LengthInBytes { get; set; }

		
		public object Clone()
        {
			DiscreteLocation discLocation = new DiscreteLocation();
			discLocation.Discrete = Discrete;
			discLocation.StartAddress = StartAddress;
			discLocation.Length = Length;
			discLocation.LengthInBytes = LengthInBytes;

			return discLocation;
        }
    }
}
