using ASME_Forms.Models;
using Microsoft.EntityFrameworkCore;

namespace ASME_Forms.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ASME_CBI> ASME_CBI { get; set; }

        public DbSet<ASME_CBI_HX> ASME_CBI_HX { get; set; }

    }
}
