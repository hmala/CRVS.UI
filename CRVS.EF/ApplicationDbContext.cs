using CRVS.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.EF
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public DbSet<DisabledType> DisabledTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Doh> Dohs { get; set; }
        public DbSet<FacilityType> FacilityTypes { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<HealthInstitution> HealthInstitutions { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Nahia> Nahias { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;
                if (entry.State==EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entity.GetType().GetProperty("IsReject").SetValue(entity,true);
                    entity.GetType().GetProperty("IsDeleted").SetValue(entity,true);
                }
            }
            return base.SaveChanges();
        
        }
    }
}
