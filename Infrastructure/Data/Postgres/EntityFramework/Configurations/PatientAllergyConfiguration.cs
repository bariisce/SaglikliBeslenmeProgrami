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
    public class PatientAllergyConfiguration : BaseConfiguration<PatientAllergy, int>
    {
        public override void Configure(EntityTypeBuilder<PatientAllergy> builder)
        {
            base.Configure(builder);
            var data = new PatientAllergy[]
            {
                new PatientAllergy {Id=1, AllergyId=1, PatientId=1, Severity="Yüksek", ReactionDescription="Ansiyete ve sinirlilik hali", CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
