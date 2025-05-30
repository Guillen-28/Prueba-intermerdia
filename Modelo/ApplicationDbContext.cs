using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Factura> Factura { get; set; }
       
     
    }
}
