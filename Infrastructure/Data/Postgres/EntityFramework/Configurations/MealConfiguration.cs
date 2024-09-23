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
    public class MealConfiguration : BaseConfiguration<Meal, int>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            base.Configure(builder);
            var data = new Meal[]
            {
                new Meal {Id=1, MealName="Karides", CategoryId=1, Calory=99, Description="Tiroit hastaları için deniz yemeği", CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
