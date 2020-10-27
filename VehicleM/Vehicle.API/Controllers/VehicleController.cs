using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle.API.Models;
using Vehicle.Business.Repositories;
using Vehicle.Data;
using Vehicle.Data.Models;

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        IVehicleRepository _vehicleRepository;
        IMapper _mapper;

        public VehicleController(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetListVehicle()
        {
            var ls = _vehicleRepository.GetAllList();
            return Ok(ls);
        }

        [HttpPost,Route("Create")]
        public async Task<ActionResult> CreateUpdateVehicle([FromBody]VehiclesModel obj)
        {
            var md = _mapper.Map<Vehicles>(obj);
            var res =_vehicleRepository.CreateVehicle(md);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVehicle(int id)
        {
            var res = _vehicleRepository.DeleteVehicle(id);

            return Ok(res);
        }
    }
}