using Microsoft.EntityFrameworkCore;
using Scouting_v2.Models;

namespace Scouting_v2.Data
{
    public class StatsContext : DbContext
    {
        public StatsContext(DbContextOptions<StatsContext> options)
            : base(options)
        {
        }

        public DbSet<Stats> Stats { get; set; }

        public DbSet<Scouting_v2.Models.AvgMax> AvgMax { get; set; }

        public DbSet<Scouting_v2.Models.Clackamas> Clackamas { get; set; }
        public DbSet<AvgMax> Team { get; set; }
    }
}