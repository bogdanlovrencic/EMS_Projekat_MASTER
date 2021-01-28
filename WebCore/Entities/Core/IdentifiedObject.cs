using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities.Core
{
    public class IdentifiedObject
    {
        [Key]
        public int ID { get; set; }
        public string AliasName { get; set; }
        public string MRID { get; set; }
        public string Name { get; set; }
    }
}
