using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Vehicle.Business.Repositories;
using Vehicle.Data;

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        IModelsRepository _modelsRepository;
        public ModelController(IModelsRepository modelsRepository)
        {
            _modelsRepository = modelsRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetListModel()
        {
            return Ok(_modelsRepository.GetAllList());
        }
    }
}