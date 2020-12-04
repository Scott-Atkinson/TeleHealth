using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeleHealth.Core.Patients;
using TeleHealth.Core.Patients.Models;

namespace TeleHealth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<IEnumerable<PatientVm>> Get()
        {
            return await _patientService.GetPatients();
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(bool))]
        public async Task<IActionResult> SavePatient([FromBody] PatientDetail model)
        {
            await _patientService.AddPatient(model);
            return Ok();
        }
    }
}
