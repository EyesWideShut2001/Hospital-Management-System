using HospitalManagment.Models;
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

          
            // Seeding Medical Staff
          

            // Seeding Patients
            
            
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Admin) // Each department has one admin
                .WithMany(a => a.Departments) // Each admin can manage many departments
                .HasForeignKey(d => d.AdminId);
           //Seeding admin credientials
           modelBuilder.Entity<Admin>().HasData(
               new Admin { Id = 1, Username = "Alex", PasswordHash="$2a$11$L3/d85LOzJfjy5675RoK/eboyC.cPWLWT6CiqI2MfZZcxqyFdJ6D.", Email="alex@gmail.com" },
               new Admin { Id = 2, Username = "Andrei", PasswordHash="$2a$11$PV77W8GBULlBDdHDPjzrqOxu5SapTvdp0Q4MBI/HXng.fk0DUO7T2", Email="andrei@gmail.com" },
               new Admin { Id = 3, Username = "Marius", PasswordHash="$2a$11$bLvSXelGYAoFKDk1cEblauRteYRotIEaizG9iW/TCTSs7Ymsk9H72", Email="marius@gmail.com" }
           );
           
           // Seeding Departments
           modelBuilder.Entity<Department>().HasData(
               new Department { Id = 1, DepartmentName = "Cardiology", AdminId = 1 },
               new Department { Id = 2, DepartmentName = "Neurology", AdminId = 1 },
               new Department { Id = 3, DepartmentName = "Pediatrics", AdminId = 2 },
               new Department { Id = 4, DepartmentName = "Dermatology", AdminId = 3 }
           );

           modelBuilder.Entity<MedicalStaff>().HasData(
               new MedicalStaff
               {
                   Id = 1, AdminId = 1, Username = "Sara",
                   PasswordHash = "$2a$12$RvBnjdK5vod8qb02w0ZxzuafaeDZ5hUyjM.x2E1tEsardDL5tiA0y",
                   DepartmentId=1
               },
                new MedicalStaff
               {
                   Id = 2, AdminId = 1, Username = "Carina",
                   PasswordHash = "$2a$11$9Vhk6FakLIPw2oqITiyWd.5yT1RKRbg7FwZNBurvD9nLciLfmjoWm",
                   DepartmentId=1
               },
               new MedicalStaff
               {
                   Id = 3, AdminId = 1, Username = "Flavius",
                   PasswordHash = "$2a$11$xJEYrgnETzvowSCYAtPdlu13jhRZ6P02EZDF9d/XAOpW2Tq1nuSSi",
                   DepartmentId=1
               },
               new MedicalStaff
               {
                   Id = 4, AdminId = 1, Username = "George",
                   PasswordHash = "$2a$11$u5CL6ypkZPwLpRoMoN2GoO4pQ2N8HzDdvW1QD7zuIDDw9/lRnGlYy",
                   DepartmentId=1
               },
               new MedicalStaff
               {
                   Id = 5, AdminId = 1, Username = "Maria",
                   PasswordHash = "$2a$11$2JQHdcU.6ZfS.WX5pLVPluy7uJq4kB/Cn0OqpwXpzKjcb8mL1Mu/S",
                   DepartmentId=2
               },
           new MedicalStaff
               {
                   Id = 6, AdminId = 1, Username = "Ilie",
                   PasswordHash = "$2a$11$n2lPnRp6jVuKY7219WD5seyMEQzq45jxc4AZzLPSyy5opKe2ypq7O",
                   DepartmentId=2
               },
           new MedicalStaff
           {
               Id = 7, AdminId = 1, Username = "Vlad",
               PasswordHash = "$2a$11$FgkiwL3dvqrvu7O9mKuGaue8MucA5ImP283mKDCdo0kbY3fh7Jsum",
               DepartmentId=2
           },
           new MedicalStaff
           {
               Id = 8, AdminId = 2, Username = "Cristi",
               PasswordHash = "$2a$11$G6tVf7hR8ni7trHf0WZoXOUH7UbjDomgwos3Hrp1jMI7asE0vwM6a",
               DepartmentId=1
           },
           new MedicalStaff
           {
               Id = 9, AdminId = 2, Username = "Serban",
               PasswordHash = "$2a$11$eU0vuoBKQt5kOMVx3SPO8upqtosPy/tFKrFvMgUbAfvRem/FB5dcq",
               DepartmentId=1
           },
           new MedicalStaff
           {
               Id = 10, AdminId = 2, Username = "Tudor",
               PasswordHash = "$2a$11$o0UR5DQiiQq9zFm/QG28I.QCgxqZtgKhtPuklssaOvI7SiqHn3Zje",
               DepartmentId=1
           }, 
               new MedicalStaff
                   {
                       Id = 11, AdminId = 2, Username = "Alexandra",
                       PasswordHash = "$2a$11$g4zc2Jfj3I3RTUvft9Xj8elsh/Wz9Sdi8UW22cApp.tFf6RdPinCy",
                       DepartmentId=1
                   },
                new MedicalStaff
           {
               Id = 12, AdminId = 3, Username = "Marc",
               PasswordHash = "$2a$11$qrl93QvU3uPGlQIvIkfTQO3BrvYRGUC6Y/u0h7IKp4m9kPRNR/HG6",
               DepartmentId=1
           },
                new MedicalStaff
                {
                    Id = 13, AdminId = 3, Username = "Diana",
                    PasswordHash = "$2a$11$sTmnkC5GP3Dh49YA8Hix0edhTrpKNhuWAm7MN0uqle6c5CVTOaOYe",
                    DepartmentId=1
                },
                new MedicalStaff
                {
                    Id = 14, AdminId = 3, Username = "Ana",
                    PasswordHash = "$2a$11$pau9CtSFoAs.mBn83PNW1OkonJWEheD4UKGCRHuOIEyLcmUDsHfsK",
                    DepartmentId=1
                },
                new MedicalStaff
                {
                    Id = 15, AdminId = 3, Username = "Dan",
                    PasswordHash = "$2a$11$cp74W4PcfUh6FiAvAgDon.ihBt2cbBDk5hB1Vtb5oY2tnxtmntvVe",
                    DepartmentId=1
                },
                new MedicalStaff
                {
                    Id = 16, AdminId = 3, Username = "Filip",
                    PasswordHash = "$2a$11$vreICMp6.M3Z9MwUEY/TOupC05lYNJASV5S63x9LbYERBFPGtCI8G",
                    DepartmentId=1
                }
                
           );


        }
    }   
      


}
