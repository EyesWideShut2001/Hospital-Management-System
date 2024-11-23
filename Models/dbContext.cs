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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite connection string, using a local file database
            optionsBuilder.UseSqlite("Data Source=ChatApp.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Cardiology" },
                new Department { Id = 2, DepartmentName = "Neurology" },
                new Department { Id = 3, DepartmentName = "Pneumology" },
                new Department { Id = 4, DepartmentName = "Dermatology" }
            );

            // Seeding Medical Staff
          

            // Seeding Patients
           //Seeding admin credientials
           modelBuilder.Entity<Admin>().HasData(
               new Admin { Id = 1, Username = "Alex", PasswordHash="$2a$11$L3/d85LOzJfjy5675RoK/eboyC.cPWLWT6CiqI2MfZZcxqyFdJ6D.", Email="alex@gmail.com" },
               new Admin { Id = 2, Username = "Andrei", PasswordHash="$2a$11$PV77W8GBULlBDdHDPjzrqOxu5SapTvdp0Q4MBI/HXng.fk0DUO7T2", Email="andrei@gmail.com" },
               new Admin { Id = 3, Username = "Marius", PasswordHash="$2a$11$bLvSXelGYAoFKDk1cEblauRteYRotIEaizG9iW/TCTSs7Ymsk9H72", Email="marius@gmail.com" }
           );
           
        }
    }   
      


}
