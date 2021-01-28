using System;

namespace FTN.Common
{

    public enum MeasurementType
    {
        activePower,
        voltage,
        other
    }

    public enum GeneratorType
    {

        coal,

        gas,

        hydro,

        oil,

        solar,

        wind,

        other
    }

    public enum Direction
    {

        read,

        readWrite,

        write,

        other
    }

   
}
