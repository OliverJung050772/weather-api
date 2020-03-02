using Microsoft.EntityFrameworkCore;

namespace weather_api.Models
{
    public class TemperatureContext : DbContext
    {
        public TemperatureContext(DbContextOptions<TemperatureContext> options)
            : base(options)
        {
            
        }

        public DbSet<Temperature> Temperatures {get; set;}
    }
}