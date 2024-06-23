using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDeDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :base("name=DefaultConnection") 
        {
        }
        public virtual DbSet<ListaMetas> ListaMetas { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListaMetas>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<ListaMetas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ListaMetas>()
                .HasMany(e => e.Tareas)
                .WithOptional(e => e.ListaMetas)
                .HasForeignKey(e => e.IdTareas);

            modelBuilder.Entity<Tareas>()
                .Property(e => e.Tarea)
                .IsUnicode(false);
        }
    }
}