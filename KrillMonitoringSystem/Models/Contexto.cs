using Microsoft.EntityFrameworkCore;

namespace KrillMonitoringSystem.Models
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
            
        }

        public DbSet<Login> Login { get; set; }
    }
}
