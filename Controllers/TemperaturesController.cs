using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace weather_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperaturesController : ControllerBase 
    {
        private readonly ILogger<TemperaturesController> _logger;

        public TemperaturesController(ILogger<TemperaturesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            // return mock-data
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Temperature
            {
                TimeStamp = index,
                Value = (float)(rng.Next(-20, 55))
            })
            .ToArray();
        }
    }
   
}