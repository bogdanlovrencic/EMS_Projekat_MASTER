using FTN.Services.NetworkModelService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService
{
    public class NMSContext : DbContext
    {
        DbSet<DeltaSave> deltaSaves { get; set; }

        public NMSContext() : base("name=AppContextConnectionString")
        {
            //Database.SetInitializer<NMSContext>(new CreateDatabaseIfNotExists<NMSContext>());
        }
    }
}
