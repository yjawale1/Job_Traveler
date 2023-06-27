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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASME_CBI>().HasData(
                new ASME_CBI { JOB_TRAVELER_NUMBER = 377919, NATL_BD_NUMBER = "", PART_NUMBER = "151609", BASIC_TANK_NUMBER = "XB012115", HX_NUMBER = "", DESCRIPTION = "Tank VT 225" , DWG_NUMBER = "BUG32-C", MVP_NUMBER = ""},
                new ASME_CBI { JOB_TRAVELER_NUMBER = 377920, NATL_BD_NUMBER = "", PART_NUMBER = "151610", BASIC_TANK_NUMBER = "XB012116", HX_NUMBER = "", DESCRIPTION = "Tank VT 325", DWG_NUMBER = "BUG33-C", MVP_NUMBER = "" },
                new ASME_CBI { JOB_TRAVELER_NUMBER = 377921, NATL_BD_NUMBER = "", PART_NUMBER = "151611", BASIC_TANK_NUMBER = "XB012117", HX_NUMBER = "", DESCRIPTION = "Tank VT 425", DWG_NUMBER = "BUG34-C", MVP_NUMBER = "" }
                );
        }

    }
}
