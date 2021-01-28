using Microsoft.EntityFrameworkCore;
using WebApp.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Meas;
using WebApp.Entities.Wires;

namespace WebApp.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<IdentifiedObject> IdentifiedObjects { get; set; }
        public DbSet<ConductingEquipment> ConductingEquipments { get; set; }
        public DbSet<ConnectivityNodeContainer> ConnectivityNodeContainers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentContainer> EquipmentContainers { get; set; }
        public DbSet<PowerSystemResource> PowerSystemResources { get; set; }
        public DbSet<Substation> Substations { get; set; }
        public DbSet<Analog> Analogs { get; set; }
        public DbSet<Discrete> Discretes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<EnergyConsumer> EnergyConsumers { get; set; }
        public DbSet<Generator> Generators { get; set; }
        public DbSet<RegulatingCondEq> RegulatingCondEqs { get; set; }
        public DbSet<RotatingMachine> RotatingMachines { get; set; }
    }
}
