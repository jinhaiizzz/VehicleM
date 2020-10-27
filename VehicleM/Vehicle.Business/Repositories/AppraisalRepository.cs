using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public class AppraisalRepository : EntityBaseRepository<VehicleAppraisal>, IAppraisalRepository
    {
        public AppraisalRepository(VehicleDbContext vehicleDbContext) : base(vehicleDbContext)
        {

        }

        public IEnumerable<VehicleAppraisal> GetAlllist()
        {
            return base.GetAll();
        }
    }
}
