using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MessageBoard.Models;

namespace MessageBoard.Models
{
    public partial class MySQLDatabaseContext : DbContext
    {        
        public MySQLDatabaseContext(DbContextOptions<MySQLDatabaseContext> options) : base(options) { }

        public virtual DbSet<MessageBoard> Student { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<MessageBoard>(entity =>
            {
                entity.ToTable("messageboard2");

                entity.Property(e => e.MessageTime).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                   .IsRequired()
                   .HasMaxLength(128)
                   .IsUnicode(false);

            });
        }
    }
}
