using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data.Models;

namespace Vehicle.Data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicles> Vehicle { get; set; }
        public DbSet<VehicleModels> VehicleModels { get; set; }
        public DbSet<VehicleMakes> VehicleMakes { get; set; }
        public DbSet<VehicleCondition> VehicleCondition { get; set; }
        public DbSet<VehicleAppraisal> VehicleAppraisal { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
