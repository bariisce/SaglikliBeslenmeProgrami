using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class HealthRecordConfiguration : BaseConfiguration<HealthRecord, int>
    {
        public override void Configure(EntityTypeBuilder<HealthRecord> builder)
        {
            base.Configure(builder);
            var data = new HealthRecord[]
            {
                new HealthRecord{Id=1, PatientId=1, BloodPressure=120, BloodSugar= 150, Cholesterol=239, HeartRate=90, RecordedDate=new DateTime(2024,18,09), CreatedAt=DateTime.UtcNow.ToLocalTime(), IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
