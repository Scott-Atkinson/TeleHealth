using System;
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
            try
            {
                return await _patientService.GetPatients();
            }
            catch (Exception exception)
            {
                // Either log / send the exception to support 
                return await Task.FromResult<IEnumerable<PatientVm>>(null);
            }

            
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(bool))]
        public async Task<IActionResult> SavePatient([FromBody] PatientDetail model)
        {
            try
            {
                await _patientService.AddPatient(model);
                return Ok();
            }
            catch (Exception exception)
            {
                // Either log / send the exception to support 
                return BadRequest();
            }
            
        }
    }
}
