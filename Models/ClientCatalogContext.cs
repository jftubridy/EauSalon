using Microsoft.EntityFrameworkCore;

namespace ClientCatalog.Models
{
    public class ClientCatalogContext : DbContext
    {
        public virtual DbSet<Stylist> Stylists { get; set; }
        public DbSet<Client> Clients { get; set; }

        public ClientCatalogContext(DbContextOptions options) : base(options) { }
    }
}