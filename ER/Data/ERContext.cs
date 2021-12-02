using Microsoft.EntityFrameworkCore;

namespace ER.Data
{
    public class ERContext : DbContext
    {
        public ERContext(DbContextOptions<ERContext> options)
            : base(options)
        {
        }

        public DbSet<ER.Models.Specialists> Specialists { get; set; }
    }
}
