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
    public class OwnerController : ControllerBase
    {

        private readonly ILogger<OwnerController> _logger;

        public OwnerController(ILogger<OwnerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<OwnerModel> Get()
        {
            return null;
        }
    }
}
