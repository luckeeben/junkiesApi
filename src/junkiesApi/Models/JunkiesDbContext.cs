using Microsoft.Data.Entity;
using junkiesApi.Models;

namespace junkiesApi.Models
{
    public class JunkiesDbContext : DbContext
    {
        public DbSet<Quadrant> Quadrants { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<SectorWarp> SectorWarps { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Ship> Ships { get; set; }
    }
}
