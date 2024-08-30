using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Authorize(Policy = "MedicalStaffPolicy")]
    public class MedicalStaffController : Controller
    {
        // Actions for managing their own patients
    }
}
