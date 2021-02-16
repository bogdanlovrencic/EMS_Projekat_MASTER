using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionContract
{
    public class ArgumentCaller : EventArgs
    {
        public string Method { get; set; }
    }
}
