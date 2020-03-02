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
    public class PropertyController : ControllerBase
    {

        private readonly ILogger<PropertyController> _logger;

        public PropertyController(ILogger<PropertyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PropertyModel> Get()
        {
            return null;
        }
    }
}
