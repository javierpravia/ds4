using System.Data.Entity;
using SistemaPasaportes.Models;

namespace SistemaPasaportes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            // Deshabilitar inicializador para no modificar la BD existente
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public DbSet<Pasaporte> Pasaportes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapear el modelo Pasaporte a la tabla JP_Pasaportes
            modelBuilder.Entity<Pasaporte>().ToTable("JP_Pasaportes");

            base.OnModelCreating(modelBuilder);
        }
    }
}