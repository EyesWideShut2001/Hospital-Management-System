using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HospitalManagment.Models;
using Hospital_Managment.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    //[Authorize(Policy = "DepartmentHeadPolicy")]
    public class DepartmentController : Controller //pt departamentul specific unui admin
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ViewMedicalStaff(int id)
        {
            var medicalStaff = _context.MedicalStaffs
                .Where(ms => ms.DepartmentId == id) // Assuming DepartmentId is a property in MedicalStaff
                .ToList();

            return View(medicalStaff);
        }

        public IActionResult ViewPatients(int id)
        {
            var patients = _context.Patients
                .Where(p => p.DepartmentId == id)
                .ToList();

            return View(patients);
        }

        public IActionResult ViewInformation(int id)
        {
            var department = _context.Departments
                .FirstOrDefault(d => d.Id == id);

            return View(department);
        }
        // Action to display department details
        public IActionResult ViewDetails(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == id);

            if (department == null)
            {
                return NotFound("Department not found.");
            }

            return View(department);
        }
        
        // Action to handle the form submission for editing department details
        [HttpGet]
        public IActionResult EditDetails(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == id);
            if (department == null)
            {
                return NotFound("Department not found.");
            }

            return View(department);
        }

// POST: Handles the form submission after editing
        [HttpPost]
        public IActionResult EditDetails(Department updatedDepartment)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == updatedDepartment.Id);

            if (department == null)
            {
                return NotFound("Department not found.");
            }

            // Update fields
            department.Location = updatedDepartment.Location;
            department.FoundedDate = updatedDepartment.FoundedDate;
            department.MainDoctor = updatedDepartment.MainDoctor;
            department.Description = updatedDepartment.Description;
            department.Accreditations = updatedDepartment.Accreditations;

            _context.SaveChanges();

            return RedirectToAction("ViewDetails", new { id = department.Id });
        }
    }

}
