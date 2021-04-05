using Microsoft.EntityFrameworkCore;

namespace barista.api.Models
{
    public class VisitorContext : DbContext
    {

        public VisitorContext(DbContextOptions<VisitorContext> options) : base(options) { }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
