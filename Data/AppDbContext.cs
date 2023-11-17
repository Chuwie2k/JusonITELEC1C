using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JusonITELEC1C.Models;

namespace JusonITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Vince Albert",
                    LastName = "Juson",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2020-09-25"),
                    GPA = 1.5,
                    Email = "vincealbert.juson.cics@ust.edu.ph",
                    Phone = "+639951778731",
                    Address = "31 C. Parsons Drive BF Homes, Paranaque City, Metro Manila ,Philippines"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Vince Albert",
                    LastName = "Juson",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2021-09-25"),
                    GPA = 1,
                    Email = "vincealbert.juson.cics@ust.edu.ph",
                    Phone = "+638851778731",
                    Address = "31 C. Parsons Drive BF Homes, Paranaque City, Metro Manila ,Philippines"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Vince Albert",
                    LastName = "Juson",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2022-09-25"),
                    GPA = 1.5,
                    Email = "vincealbert.juson.cics@ust.edu.ph",
                    Phone = "+638851778731",
                    Address = "31 C. Parsons Drive BF Homes, Paranaque City, Metro Manila ,Philippines"
                }
                );
        }
    }
}