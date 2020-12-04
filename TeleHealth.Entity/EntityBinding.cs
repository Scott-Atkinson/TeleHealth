using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TeleHealth.Entity.Context;

namespace TeleHealth.Entity
{
    public static class EntityBinding
    {
        public static async Task SetupEntity(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<ApplicationDbContext>();

                await context.Database.MigrateAsync();
            }
        }
    }
}
