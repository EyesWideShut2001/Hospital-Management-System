using Hospital_Managment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagment.Models

{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalStaff> MedicalStaffs { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Cardiology" },
                new Department { Id = 2, DepartmentName = "Neurology" }
            );

            // Seeding Medical Staff
            modelBuilder.Entity<MedicalStaff>().HasData(
                new MedicalStaff { Id = 1, Name = "Dr. A" },
                new MedicalStaff { Id = 2, Name = "Dr. B" }
            );

            // Seeding Patients
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, Name = "John Doe", DateOfBirth = new DateTime(1980, 1, 1), MedicalRecord = "Healthy", DepartmentId = 1, AssignedDoctorId = 1 },
                new Patient { Id = 2, Name = "Jane Smith", DateOfBirth = new DateTime(1985, 5, 15), MedicalRecord = "Healthy", DepartmentId = 2, AssignedDoctorId = 2 }
            );

        }
    }   
      


}
