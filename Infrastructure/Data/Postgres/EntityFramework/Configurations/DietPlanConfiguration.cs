using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                    StartDate = new DateTime(2024, 11, 11), EndDate = new DateTime(2025, 10, 10),
                    CaloriesPerDay = 200,
                    Details = "Tiroit hastalığından dolayı alman gereken kalori miktarına dikkat etmelisin !",
                    CreatedAt = DateTime.UtcNow.Date, IsDeleted = false
                }
            };
            builder.HasData(data);
        }
    }
}
