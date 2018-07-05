using Microsoft.EntityFrameworkCore;

namespace AMINEV02.Models
{
    public class AMINEV02Context : DbContext
    {
        public AMINEV02Context (DbContextOptions<AMINEV02Context> options)
            : base(options)
        {
        }

        public DbSet<AMINEV02.Models.Gaeste> Gaeste { get; set; }
    }
}