using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientUIApp.GDA
{
    public class MainHelper
    {
        public static List<ModelCode> AllTypesModelCodes = new List<ModelCode>()
        {
            ModelCode.CONNODE,
            ModelCode.SERCOMPENSATOR,
            ModelCode.DCLINESEG,
            ModelCode.ACLINESEG,
            ModelCode.PLENSIM,
            ModelCode.TERMINAL
        };
    }
}
