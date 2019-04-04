using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DAB2.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<CourseStudent> CourseStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For Course and Teacher
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

            //For Course and Assignment 
            modelBuilder.Entity<CourseAssignment>()
                .HasKey(ca => new {ca.CourseId, ca.AssignmentId});

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(c => c.Course)
                .WithMany(ca => ca.CourseAssignment)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(a => a.Assignment)
                .WithMany(ca => ca.CourseAssignment)
                .HasForeignKey(a => a.AssignmentId);

            modelBuilder.Entity<CourseStudent>().HasKey(p => new {p.StudentID, p.CourseID});
            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(cs => cs.CourseID);
            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(s => s.CourseStudents)
                .HasForeignKey(cs => cs.StudentID);
        }
    }

}
