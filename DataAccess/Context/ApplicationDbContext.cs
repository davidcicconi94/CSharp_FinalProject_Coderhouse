using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project_Coderhouse.Models;


namespace Coder.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) 
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                const string CONNECTION_STRING = "Data Source=localhost\\SQLExpress;Initial Catalog=coderhouse;Integrated Security=True;Trust Server Certificate=True";
                optionsBuilder.UseSqlServer(CONNECTION_STRING);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasKey(p => p.Id); 

            modelBuilder.Entity<ProductoVendido>() 
                .HasKey(p => p.Id);

            modelBuilder.Entity<Usuario>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Venta>()
                .HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public virtual DbSet<Producto> Productos { get; set; } 
        public virtual DbSet<ProductoVendido> ProductoVendidos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Venta { get; set; } 
        #endregion
      
    }
}
