using Entraides.Services.NecessiteuxAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Entraides.Services.NecessiteuxAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Benevole>Benevoles { get; set; }

    }
}
