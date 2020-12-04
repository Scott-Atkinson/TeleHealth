using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TeleHealth.Core.Mappings;
using TeleHealth.Core.Patients;
using TeleHealth.Entity;

namespace TeleHealth.Core
{
    public static class CoreBindings
    {
        public static IServiceCollection ConfigureCoreBindings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddScoped<IPatientService, PatientService>()
                           .AddAutoMapper(typeof(MappingProfile));
        }

        public static async Task SetupCore(this IServiceProvider serviceProvider)
        {
            await serviceProvider.SetupEntity();
        }
    }
}
