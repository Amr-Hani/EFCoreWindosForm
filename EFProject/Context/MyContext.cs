using EFProject.Configurations;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Context
{
    public class MyContext : DbContext
    {
        //DESKTOP-RDA8E65 //ServerName
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RDA8E65;DataBase=SchoolSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region Ins CrsSession Configuration
            modelBuilder.ApplyConfiguration(new InsCrsSessionConfg());
            #endregion

            #region Ins Department Configuration
            modelBuilder.ApplyConfiguration(new InsMangedDepartment());
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #region Tables
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<CousreStudent> CousreStudents { get; set; }
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        #endregion
    }
}
