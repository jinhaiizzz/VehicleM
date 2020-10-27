using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public class VehicleRepository : EntityBaseRepository<Vehicles>, IVehicleRepository
    {
        public VehicleRepository(VehicleDbContext vehicleDbContext) : base(vehicleDbContext)
        {

        }

        public IEnumerable<Vehicles> GetAllList()
        {
            return base.GetAll();
        }

        public bool CreateVehicle(Vehicles obj)
        {
            try
            {
                if(obj.ID == 0)
                {
                    base.Add(obj);
                }
                else
                {
                    base.Update(obj);
                }
                base.Commit();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeleteVehicle(int id)
        {
            var md = base.FindBy(x => x.ID == id).FirstOrDefault();
            base.Delete(md);
            base.Commit();
            return true;
        }
    }
}
