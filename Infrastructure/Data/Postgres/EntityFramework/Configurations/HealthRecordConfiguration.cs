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
    public class HealthRecordConfiguration : BaseConfiguration<HealthRecord, int>
    {
        public override void Configure(EntityTypeBuilder<HealthRecord> builder)
        {
            base.Configure(builder);
            var data = new HealthRecord[]
            {
                new HealthRecord{Id=1, PatientId=1, BloodPressure=120, BloodSugar= 150, Cholesterol=239, HeartRate=90, RecordedDate= DateTimeKind.Utc, CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
