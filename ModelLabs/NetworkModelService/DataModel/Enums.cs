using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel
{
    public enum MeasurementType
    {
        activePower,
        voltage,
    }

    public enum GeneratorType
    {

        coal,

        gas,

        hydro,

        oil,

        solar,

        wind,
    }

    public enum Direction
    {

        read,

        readWrite,

        write,
    }
}
