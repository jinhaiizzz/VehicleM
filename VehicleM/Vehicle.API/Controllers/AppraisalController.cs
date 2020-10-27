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
    public class AppraisalController : ControllerBase
    {
        IAppraisalRepository _appraisalRepository;
        public AppraisalController(IAppraisalRepository appraisalRepository)
        {
            _appraisalRepository = appraisalRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetListAppraisal()
        {
            return Ok(_appraisalRepository.GetAlllist());
        }
    }
}