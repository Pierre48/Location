using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Location.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Location.WebApi.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class LeaseController : ControllerBase
    {

        private readonly ILogger<LeaseController> _logger;

        public LeaseController(ILogger<LeaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LeaseModel> Get()
        {
            return new List<LeaseModel>{ new LeaseModel{StartDate = DateTime.Now},new LeaseModel{StartDate = DateTime.Now},new LeaseModel{StartDate = DateTime.Now},new LeaseModel{StartDate = DateTime.Now},new LeaseModel{StartDate = DateTime.Now}};
        }
    }
}
