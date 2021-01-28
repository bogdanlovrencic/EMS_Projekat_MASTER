using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.Model
{
    public class DeltaSave
    {
        public int Id { get; set; }
        public byte[] DeltaInfo { get; set; }
    }
}
