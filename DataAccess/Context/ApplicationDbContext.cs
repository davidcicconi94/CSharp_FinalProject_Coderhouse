using System;
using Microsoft.EntityFrameworkCore;
using Project_Coderhouse.Models;


namespace Coder.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
