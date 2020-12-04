using AutoMapper;
using TeleHealth.Core.Patients.Models;
using TeleHealth.Entity.Patients;

namespace TeleHealth.Core.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientVm>();
            CreateMap<PatientDetail, Patient>();
        }
    }
}
