using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DAB2.Database
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext() : base() {}

        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>()
                .HasKey(ct => new {ct.CourseId, ct.TeacherId});

            modelBuilder.Entity<CourseTeacher>()
                .HasOne(c => c.Course)
                .WithMany(ct => ct.CourseTeacher)
                .HasForeignKey(ct => ct.CourseId);

            modelBuilder.Entity<CourseTeacher>()
                .HasOne(t => t.Teacher)
                .WithMany(ct => ct.CourseTeacher)
                .HasForeignKey(ct => ct.TeacherId);
        }
    }
}