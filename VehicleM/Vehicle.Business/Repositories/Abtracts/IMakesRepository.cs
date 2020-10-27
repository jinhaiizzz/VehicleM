using System.Collections.Generic;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public interface IMakesRepository
    {
        IEnumerable<VehicleMakes> GetAllList();
    }
}