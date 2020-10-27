using System.Collections.Generic;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicles> GetAllList();
        bool CreateVehicle(Vehicles obj);
        bool DeleteVehicle(int id);
    }
}