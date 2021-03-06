using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DAB2.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() {}

        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<CourseStudent> CourseStudents { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Content> Content { get; set; }

        public DbSet<GroupAssignment> GroupAssignments { get; set; }

        public DbSet<StudentGroup> StudentGroups { get; set; }

        public DbSet<CourseTeacher> CourseTeachers { get; set; }

        public DbSet<CourseAssignment> CourseAssignments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Filename=Database.db");
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DAB_AFL2;Integrated Security=True");
            //optionsBuilder.UseSqlServer("Server=tcp:dabexercise.database.windows.net,1433;Initial Catalog=DAB;Persist Security Info=False;User ID=DAB;Password=Qwerty1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer("Server=127.0.0.1,1433; Database=DAB2; User Id=SA; Password=D15987532147er!");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For Course - Teacher(many to many relationship)
            modelBuilder.Entity<CourseTeacher>()
                .HasKey(p => new {p.CourseId, p.TeacherId});

            modelBuilder.Entity<CourseTeacher>()
                .HasOne(c => c.Course)
                .WithMany(ct => ct.CourseTeacher)
                .HasForeignKey(ct => ct.CourseId);

            modelBuilder.Entity<CourseTeacher>()
                .HasOne(t => t.Teacher)
                .WithMany(ct => ct.CourseTeacher)
                .HasForeignKey(ct => ct.TeacherId);

            //For Course - Assignment(many to many relationship)
            modelBuilder.Entity<CourseAssignment>()
                .HasKey(p => new {p.CourseId, p.AssignmentId});

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(c => c.Course)
                .WithMany(ca => ca.CourseAssignment)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<CourseAssignment>()
                .HasOne(a => a.Assignment)
                .WithMany(ca => ca.CourseAssignment)
                .HasForeignKey(a => a.AssignmentId);

            // Student - Course(many to many relationship)
            modelBuilder.Entity<CourseStudent>()
                .HasKey(p => new {p.StudentID, p.CourseID});

            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(cs => cs.CourseID);
                
            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(s => s.CourseStudents)
                .HasForeignKey(cs => cs.StudentID);

            //For Student - Group(many to many relationship)
            modelBuilder.Entity<StudentGroup>()
                .HasKey(p => new {p.StudentId, p.GroupId});

            modelBuilder.Entity<StudentGroup>()
                .HasOne(s => s.Student)
                .WithMany(sg => sg.StudentGroup)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentGroup>()
                .HasOne(g => g.Group)
                .WithMany(sg => sg.StudentGroup)
                .HasForeignKey(g => g.GroupId);

            //For Group - Assignment(many to many relationship)
            modelBuilder.Entity<GroupAssignment>()
                .HasKey(p => new {p.GroupId, p.AssignmentId});

            modelBuilder.Entity<GroupAssignment>()
                .HasOne(g => g.Group)
                .WithMany(ga => ga.GroupAssignment)
                .HasForeignKey(g => g.GroupId);

            modelBuilder.Entity<GroupAssignment>()
                .HasOne(a => a.Assignment)
                .WithMany(ga => ga.GroupAssignment)
                .HasForeignKey(a => a.AssignmentId);

            //One to one Course and Content
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Content)
                .WithOne(c => c.Course)
                .HasForeignKey<Content>();

            //One to Many (Teacher can give many grades to assigments)
            modelBuilder.Entity<GroupAssignment>()
                .HasOne(ga => ga.Teacher)
                .WithMany(t => t.GroupAssignment)
                .HasForeignKey(ga => ga.TeacherId);
        }
    }
}
