using System.Collections.Generic;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllList();
    }
}