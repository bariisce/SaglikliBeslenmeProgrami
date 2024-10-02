﻿using Infrastructure.Data.Postgres.Entities;
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
    public class DietitianConfiguration : BaseConfiguration<Dietitian, int>
    {
        public override void Configure(EntityTypeBuilder<Dietitian> builder)
        {
            base.Configure(builder);
            var data = new Dietitian[]
            {
                new Dietitian 
                { 
                    Id=1,
                    UserId=1,
                    Specialization="Diyabet Diyetisyeni",
                    ExperienceYears=1,
                    IsActive=true,
                    CreatedAt=DateTime.UtcNow.ToTimeZone(), 
                    IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
