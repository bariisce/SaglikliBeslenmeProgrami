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
    public class PatientConfiguration : BaseConfiguration<Patient, int>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);

            var data = new Patient[]
            {
                new Patient
                {
                    Id = 1,
                    UserId = 2,
                    Weight=70,
                    Height= 178,
                    MedicalConditions="Tiroid Hastalığı",
                    Medications="Levotiron, Tefor, Euthyrox",
                    CreatedAt=DateTime.UtcNow.ToTimeZone(),
                    IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
