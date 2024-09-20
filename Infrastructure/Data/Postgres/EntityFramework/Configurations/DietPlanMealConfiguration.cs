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
    public class DietPlanMealConfiguration : BaseConfiguration<DietPlanMeal, int>
    {
        public override void Configure(EntityTypeBuilder<DietPlanMeal> builder)
        {
            base.Configure(builder);
            var data = new DietPlanMeal[]
            {
                new DietPlanMeal{Id=1, DietPlanId=1, MealId=1, ServingSize=2, CreatedAt=DateTime.UtcNow.Date, IsDeleted=false},

            };
            builder.HasData(data);
        }
    }
}
