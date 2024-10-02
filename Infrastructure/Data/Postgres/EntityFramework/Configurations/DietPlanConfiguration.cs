using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Utilities;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DietPlanConfiguration : BaseConfiguration<DietPlan, int>
    {
        public override void Configure(EntityTypeBuilder<DietPlan> builder)
        {
            base.Configure(builder);
            var data = new DietPlan[]
            {
                new DietPlan
                {
                    Id = 1,
                    DietitianId = 1,
                    PatientId = 1,
                    DietPlanName="Kilo Verme Programı",
                    StartDate = "2024-11-11", 
                    EndDate = "2025-06-10",
                    CaloriesPerDay = 200,
                    Details = "Tiroit hastalığından dolayı alman gereken kalori miktarına dikkat etmelisin !",
                    Status = true,
                    CreatedAt = DateTime.UtcNow.ToTimeZone(), IsDeleted = false
                }
            };
            builder.HasData(data);
        }
    }
}
