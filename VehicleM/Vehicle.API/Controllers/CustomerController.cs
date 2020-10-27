using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle.Business.Repositories;
using Vehicle.Data;

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //private readonly VehicleDbContext _vehicleDbContext;
        //public CustomerController(VehicleDbContext vehicleDbContext)
        //{
        //    _vehicleDbContext = vehicleDbContext;
        //    //check db
        //    _vehicleDbContext.Database.EnsureCreated();
        //}

        ICustomerRepository customerRepo;

        public CustomerController(ICustomerRepository customerRepository)
        {
            customerRepo = customerRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetListCustomer()
        {
            //var ls = _vehicleDbContext.Customer.ToList();
            var ls = customerRepo.GetAllList();
            return Ok(ls);
        }

        //[HttpGet, Route("Customer/{id}")]
        //[HttpGet("{id}")]
        //public IActionResult GetCustomer(int id)
        //{
        //    return Ok(_vehicleDbContext.Customer.Find(id));
        //}

    }
}