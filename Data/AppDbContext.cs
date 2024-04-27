using LoginSignup.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSignup.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<PasswordHistory> PasswordHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasOne(p => p.User)
                .WithOne(u => u.Profile)
                .HasForeignKey<Profile>(p => p.UserID);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.User)
                .WithOne(u => u.Enrollment)
                .HasForeignKey<Enrollment>(e => e.UserID);

            modelBuilder.Entity<PasswordHistory>()
               
                .HasOne(ph => ph.User)
                .WithOne(u => u.PasswordHistory)
                .HasForeignKey<PasswordHistory>(ph => ph.UserID);
        }
    }

}
