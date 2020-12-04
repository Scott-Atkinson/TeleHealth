using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeleHealth.Core.Patients.Models;
using TeleHealth.Entity.Context;
using TeleHealth.Entity.Patients;

namespace TeleHealth.Core.Patients
{
    internal class PatientService : IPatientService
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public PatientService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<bool> AddPatient(PatientDetail patientDetail)
        {
            var patient = _mapper.Map<Patient>(patientDetail);

            await _applicationDbContext.Patients.AddAsync(patient);

            await _applicationDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IList<PatientVm>> GetPatients()
        {
            var patients = await _applicationDbContext.Patients.ToListAsync();
            return _mapper.Map<IList<PatientVm>>(patients);
        }
    }
}
