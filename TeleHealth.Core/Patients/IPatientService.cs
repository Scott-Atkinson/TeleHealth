using System.Collections.Generic;
using System.Threading.Tasks;
using TeleHealth.Core.Patients.Models;

namespace TeleHealth.Core.Patients
{
    public interface IPatientService
    {
        Task<bool> AddPatient(PatientDetail patientDetail);
        Task<IList<PatientVm>> GetPatients();

    }
}
