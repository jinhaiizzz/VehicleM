using System.Collections.Generic;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public interface IModelsRepository
    {
        IEnumerable<VehicleModels> GetAllList();
    }
}