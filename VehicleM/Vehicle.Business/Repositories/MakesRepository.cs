using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public class MakesRepository : EntityBaseRepository<VehicleMakes>, IMakesRepository
    {
        public MakesRepository(VehicleDbContext vehicleDbContext) : base(vehicleDbContext)
        {

        }

        public IEnumerable<VehicleMakes> GetAllList()
        {
            return base.GetAll();
        }
    }
}
