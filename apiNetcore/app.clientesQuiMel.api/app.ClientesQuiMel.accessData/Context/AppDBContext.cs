using Microsoft.EntityFrameworkCore;

namespace app.ClientesQuiMel.dataAccess.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext()
        {
             public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DireccionCliente> DireccionClientes { get; set; }

    }
        }

    }
}
