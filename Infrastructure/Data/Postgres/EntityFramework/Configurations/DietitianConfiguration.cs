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
                    Specialization="Diyabet Diyetisyeni", 
                    UserId=1, 
                    CreatedAt=DateTime.UtcNow.Date, 
                    IsDeleted=false}
            };
            builder.HasData(data);
        }
    }
}
