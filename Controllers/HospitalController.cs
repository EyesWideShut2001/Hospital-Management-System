using Microsoft.AspNetCore.Mvc;


namespace Hospital_Managment.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly HospitalService _hospitalService;

        public HospitalsController(HospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpPost]
        public IActionResult CreateHospital(string hospitalName, string adminEmail)
        {
            var hospital = _hospitalService.CreateHospital(hospitalName, adminEmail);

            // Return a view or redirect with the created hospital details
            return View("HospitalCreated", hospital);
        }
    }
}
