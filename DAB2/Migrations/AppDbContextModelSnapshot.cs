﻿// <auto-generated />
using DAB2.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAB2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAB2.Database.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DueDate")
                        .IsRequired();

                    b.Property<int>("GroupSize");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("DAB2.Database.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AudioLink")
                        .IsRequired();

                    b.Property<int>("BinaryData");

                    b.Property<string>("ContentAreaId");

                    b.Property<int>("CourseId");

                    b.Property<string>("CourseId1");

                    b.Property<string>("GroupSignupLink")
                        .IsRequired();

                    b.Property<string>("VideoLink")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CourseId1")
                        .IsUnique()
                        .HasFilter("[CourseId1] IS NOT NULL");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("DAB2.Database.Course", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseNr");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DAB2.Database.CourseAssignment", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<int>("AssignmentId");

                    b.Property<bool>("Active");

                    b.HasKey("CourseId", "AssignmentId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("CourseAssignment");
                });

            modelBuilder.Entity("DAB2.Database.CourseStudent", b =>
                {
                    b.Property<int>("StudentID");

                    b.Property<string>("CourseID");


                    b.Property<string>("Grade");

                    b.Property<bool>("IsCourseActive");

                    b.Property<bool>("IsCoursePassed");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("CourseStudents");
                });

            modelBuilder.Entity("DAB2.Database.CourseTeacher", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<int>("TeacherId");

                    b.Property<bool>("IsAssistant");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CourseTeachers");
                });

            modelBuilder.Entity("DAB2.Database.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupNr");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DAB2.Database.GroupAssignment", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("AssignmentId");

                    b.Property<string>("Grade");

                    b.Property<int>("TeacherId");

                    b.HasKey("GroupId", "AssignmentId");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("GroupAssignments");
                });

            modelBuilder.Entity("DAB2.Database.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuId")
                        .IsRequired();

                    b.Property<string>("EnrolledDate")
                        .IsRequired();

                    b.Property<string>("GraduationDate")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DAB2.Database.StudentGroup", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("GroupId");

                    b.HasKey("StudentId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("StudentGroups");
                });

            modelBuilder.Entity("DAB2.Database.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuId")
                        .IsRequired();

                    b.Property<string>("Birthday")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DAB2.Database.Content", b =>
                {
                    b.HasOne("DAB2.Database.Course", "Course")
                        .WithOne("Content")
                        .HasForeignKey("DAB2.Database.Content", "CourseId1");
                });

            modelBuilder.Entity("DAB2.Database.CourseAssignment", b =>
                {
                    b.HasOne("DAB2.Database.Assignment", "Assignment")
                        .WithMany("CourseAssignment")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Course", "Course")
                        .WithMany("CourseAssignment")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2.Database.CourseStudent", b =>
                {
                    b.HasOne("DAB2.Database.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Student", "Student")
                        .WithMany("CourseStudents")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2.Database.CourseTeacher", b =>
                {
                    b.HasOne("DAB2.Database.Course", "Course")
                        .WithMany("CourseTeacher")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Teacher", "Teacher")
                        .WithMany("CourseTeacher")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2.Database.GroupAssignment", b =>
                {
                    b.HasOne("DAB2.Database.Assignment", "Assignment")
                        .WithMany("GroupAssignment")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Group", "Group")
                        .WithMany("GroupAssignment")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Teacher", "Teacher")
                        .WithMany("GroupAssignment")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAB2.Database.StudentGroup", b =>
                {
                    b.HasOne("DAB2.Database.Group", "Group")
                        .WithMany("StudentGroup")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAB2.Database.Student", "Student")
                        .WithMany("StudentGroup")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
