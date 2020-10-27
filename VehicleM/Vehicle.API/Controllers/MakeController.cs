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
    public class MakeController : ControllerBase
    {
        IMakesRepository _makesRepository;

        public MakeController(IMakesRepository makesRepository)
        {
            _makesRepository = makesRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetListMake()
        {
            return Ok(_makesRepository.GetAllList());
        }
    }
}