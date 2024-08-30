using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Authorize(Policy = "DepartmentHeadPolicy")]
    public class DepartmentHeadController : Controller
    {
        // Actions for managing patients within their department
    }
}
