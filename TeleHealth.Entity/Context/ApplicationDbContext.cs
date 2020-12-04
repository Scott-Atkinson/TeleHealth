using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TeleHealth.Entity.Patients;

namespace TeleHealth.Entity.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {

            var entities = ChangeTracker.Entries();

            foreach (var addedEntity in ChangeTracker.Entries().Where(x => x.State == EntityState.Added))
            {
                addedEntity.Property("CreatedDate").CurrentValue = DateTime.Now;
            }

            foreach (var modifiedEntity in ChangeTracker.Entries().Where(x => x.State == EntityState.Modified))
            {
                modifiedEntity.Property("UpdatedDate").CurrentValue = DateTime.Now;
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
