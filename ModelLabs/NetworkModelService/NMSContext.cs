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
        public DbSet<DeltaSave> deltaSaves { get; set; }

        public NMSContext() : base("AppContextConnectionString")
        {
            //Database.SetInitializer<NMSContext>(new CreateDatabaseIfNotExists<NMSContext>());
        }
    }
}
