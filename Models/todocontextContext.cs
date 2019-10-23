using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using openswaggerNswag.Models;

namespace openswaggerNswag.Models
{
    public partial class todocontextContext : DbContext
    {
        public todocontextContext()
        {
        }

        public todocontextContext(DbContextOptions<todocontextContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Todoitems> Todoitems { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todoitems>(entity =>
            {
                entity.ToTable("todoitems", "todocontext");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.IsComplete).HasColumnType("bit(1)");

                entity.Property(e => e.Name).IsUnicode(false);
            });
        }

        

        public DbSet<openswaggerNswag.Models.Employee> Employee { get; set; }
    }
}
