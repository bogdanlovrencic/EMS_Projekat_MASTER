using FTN.Services.NetworkModelService.DataModel.Meas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementCommon
{
    public class AnalogLocation : ICloneable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalogLocation" /> class
        /// </summary>
        public AnalogLocation()
        {

        }
        /// <summary>
        /// Gets or sets Analog of the entity
        /// </summary>
        public Analog Analog { get; set; }

        /// <summary>
        /// Gets or sets StartAddress of the entity
        /// </summary>
        public int StartAddress { get; set; }

        /// <summary>
        /// Gets or sets Length of the entity 
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets Length of the entity in bytes
        /// </summary>
        public int LengthInBytes { get; set; }

        public object Clone()
        {
            AnalogLocation analLocation = new AnalogLocation();
            analLocation.Analog = Analog;
            analLocation.StartAddress = StartAddress;
            analLocation.Length = Length;
            analLocation.LengthInBytes = LengthInBytes;

            return analLocation;
        }
    }
}
