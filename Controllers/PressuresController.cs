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
    public class PressuresController : ControllerBase 
    {
        private readonly ILogger<PressuresController> _logger;

        public PressuresController(ILogger<PressuresController> logger)
        {
            _logger = logger;
        }

        // GET: /Pressures
        [HttpGet]
        public IEnumerable<Pressure> Get()
        {
            // return mock-data for barometic pressure
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new Pressure
            {
                TimeStamp = index + 1000,
                Value = (float)(rng.Next(1080, 1150))
            })
            .ToArray();
        }
    }
   
}