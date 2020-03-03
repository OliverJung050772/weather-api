using Microsoft.EntityFrameworkCore;

namespace weather_api.Models
{
    public class PressureContext : DbContext
    {
        public PressureContext(DbContextOptions<PressureContext> options)
            : base(options)
        {
            
        }

        public DbSet<Pressure> Pressures {get; set;}
    }
}