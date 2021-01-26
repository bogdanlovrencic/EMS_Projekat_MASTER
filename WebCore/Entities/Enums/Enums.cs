using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities.Enums
{
    public enum Direction
    {

        read,

        readWrite,

        write,

        other
    }

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
}
