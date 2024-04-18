using Microsoft.EntityFrameworkCore;
using PruebaCovisian.Models;

namespace PruebaCovisian
{
    public class AlquilerContext: DbContext
    {
        public AlquilerContext(DbContextOptions<AlquilerContext> options): base(options)
        {
        }
        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pagos> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
