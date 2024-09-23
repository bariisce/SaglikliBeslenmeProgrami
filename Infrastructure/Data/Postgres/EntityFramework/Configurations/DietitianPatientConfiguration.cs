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
    public class DietitianPatientConfiguration : BaseConfiguration<DietitianPatient, int>
    {
        public override void Configure(EntityTypeBuilder<DietitianPatient> builder)
        {
            base.Configure(builder);
            var data = new DietitianPatient[]
            {
                new DietitianPatient{Id=1, DietitianId=1, PatientId=1, DietPlanId=1, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false},
            };
            builder.HasData(data);
        }
    }
}
