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
    public class MealRecipeConfiguration : BaseConfiguration<MealRecipe, int>
    {
        public override void Configure(EntityTypeBuilder<MealRecipe> builder)
        {
            base.Configure(builder);
            var data = new MealRecipe[]
            {
                new MealRecipe{Id=1, MealId=1, Ingredients="Yarım kilo temizlenmiş ve dondurulmuş karides, 3 diş sarımsak, 6 yemek kaşığı zeytinyağı, 1 çay kaşığı pul biber, 1 çay kaşığı toz kırmızı biber (olmasa da olur), 1 çay kaşığından az karabiber, 1 çay kaşığı tuz, 3 yemek kaşığı limon suyu", Instructions="Yemeği Yapma Adımları", PreparationTime="30 dakika", CookingTime="20 dakika",CreatedAt=DateTime.UtcNow.ToTimeZone(), IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
