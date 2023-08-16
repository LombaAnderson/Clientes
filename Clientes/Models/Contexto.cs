using Microsoft.EntityFrameworkCore;

namespace Clientes.Models
{
    public class Contexto: DbContext
    {

        public Contexto (DbContextOptions<Contexto> options) : base (options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; } 
    }
}
