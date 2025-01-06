using ConsumirApiExterna.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsumirApiExterna.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) :
            base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<DateOfBirth> DateOfBirths { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Registered> Registrations { get; set; }
        public DbSet<Id> Ids { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }
        public DbSet<Timezone> Timezones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Name>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(n => n.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Location>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(l => l.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Login>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(l => l.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DateOfBirth>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Registered>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(r => r.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Id>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(i => i.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Picture>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(p => p.IdUsuario)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}