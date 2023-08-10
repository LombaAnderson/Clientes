using Microsoft.EntityFrameworkCore;

namespace Clientes.Data
{
    public class ClientesAPIDbContext: DbContext
    {

        public ClientesAPIDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Cliente>Clientes { get; set;}
    }
}
