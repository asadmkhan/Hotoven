using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotOven.Models
{
    public partial class HotOvenContext : DbContext
    {
        public HotOvenContext()
        {
        }

        public HotOvenContext(DbContextOptions<HotOvenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotOven;Integrated Security=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ProductName).HasMaxLength(100);
            });
        }
    }
}
