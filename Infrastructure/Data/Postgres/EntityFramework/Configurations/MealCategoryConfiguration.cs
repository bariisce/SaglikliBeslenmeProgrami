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
    public class MealCategoryConfiguration : BaseConfiguration<MealCategory, int>
    {
        public override void Configure(EntityTypeBuilder<MealCategory> builder)
        {
            base.Configure(builder);
            var data = new MealCategory[]
            {
                new MealCategory
                {
                    Id=1,
                    CategoryName="Deniz Yemekleri",
                    Description="b12 ve demir eksikliği olanlar için",
                    CreatedAt=DateTime.UtcNow.Date,
                    IsDeleted=false
                }
            };
            builder.HasData(data);
        }
    }
}
