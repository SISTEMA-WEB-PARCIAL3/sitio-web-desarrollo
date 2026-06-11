usign Microsoft.EntityFrameworkCore;

namespace SitioWeb.Models
{
    public class AplicationDbContext : DbContext{
        public DbSet<Usuario> Reportes {get; set;}
    }
}