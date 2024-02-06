using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project_Coderhouse.Entities;

namespace Coder.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IConfiguration configuration
        )
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    const string CONNECTION_STRING =
                        "Data Source=localhost\\SQLExpress;Initial Catalog=coderhouse;Integrated Security=True;Trust Server Certificate=True";
                    optionsBuilder.UseSqlServer(CONNECTION_STRING);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al configurar la conexión: {ex.Message}");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasKey(p => p.Id);

            modelBuilder.Entity<ProductoVendido>().HasKey(p => p.Id);

            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);

            modelBuilder.Entity<Venta>().HasKey(p => p.Id);


            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<ProductoVendido> ProductoVendidos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;
        #endregion
    }
}
