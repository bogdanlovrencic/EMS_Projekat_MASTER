using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementCommon
{
    public class Converter
    {
        public Converter()
        {

        }

        public float ConvertRawToEGUValue(float scalingFactor,float deviation,float rawValue)
        {

            float retVal = scalingFactor * rawValue + deviation;
            return retVal;
        }

        public float ConvertEGUToRawValue(float scalingFactor,float deviation,float eguValue)
        {
         
            float retVal = (eguValue - deviation) / scalingFactor;
            return retVal;
        }
    }
}
