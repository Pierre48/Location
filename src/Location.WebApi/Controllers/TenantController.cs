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
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class TenantController : ControllerBase
    {

        private readonly ILogger<TenantController> _logger;

        public TenantController(ILogger<TenantController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TenantModel> Get()
        {
            return null;
        }
    }
}
