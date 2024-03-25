using Microsoft.EntityFrameworkCore;
using System.IO;


namespace DataAccess.Models
{
    public partial class DbCrudContext : DbContext    
    {
        public DbCrudContext()
        {
        }

        public DbCrudContext(DbContextOptions<DbCrudContext> options) : base(options)
        {
        }        

        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<TipoPermisos> TipoPermisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
