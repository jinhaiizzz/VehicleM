using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.Business.Repositories
{
    public class CustomerRepository : EntityBaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(VehicleDbContext vehicleDbContext) : base(vehicleDbContext)
        {

        }

        public IEnumerable<Customer> GetAllList()
        {
            return base.GetAll();
        }
    }
}
