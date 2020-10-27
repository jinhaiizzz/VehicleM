using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public class ModelsRepository : EntityBaseRepository<VehicleModels>, IModelsRepository
    {
        public ModelsRepository(VehicleDbContext vehicleDbContext) : base(vehicleDbContext)
        {

        }

        public IEnumerable<VehicleModels> GetAllList()
        {
            return base.GetAll();
        }
    }
}
