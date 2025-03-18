using EFCoreA1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreA1
{
    internal class ITIDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = ITICodeFirst; Trusted_Connection= True; TrustServerCertificate= True");
            
            
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                        .HasMany(D=>D.Instructors)
                        .WithOne(Ins=>Ins.InstructorDepartment)
                        .HasForeignKey(Ins=>Ins.Id)
                        .OnDelete(DeleteBehavior.NoAction);
        }

        DbSet<Student> Students { get; set; }   
        DbSet<Course> Courses { get; set; }
        DbSet<Stud_Course> Stud_Course { get; set; }//However the name of the table in the database will be Stud_Course as the data annotation method has higher priority
        DbSet<Department> Departments { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Course_Inst> course_Insts { get; set; }
        DbSet<Topic> Topics { get; set; }


    }
}
