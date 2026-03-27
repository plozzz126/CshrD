using Microsoft.EntityFrameworkCore;

namespace Step.Hotel.Atr.RealPortal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<R_Room> R_Rooms { get; set; }
        public DbSet<R_Client> R_Clients { get; set; }
        public DbSet<R_Team> R_Teams { get; set; }
        
    }
}
