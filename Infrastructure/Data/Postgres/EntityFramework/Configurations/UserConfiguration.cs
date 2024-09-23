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
    public class UserConfiguration : BaseConfiguration<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            var data = new User[]
            {
                new User
                {
                    Id = 1, Name="Barış",
                    Surname="Ceylan",
                    RoleId=2,
                    Age=22,
                    BirthDate=DateTimeKind.Utc,
                    Email="barisceylan907@gmail.com",
                    Gender="Erkek",
                    Password="baris.C123",
                    PhoneNumber="05305137988",
                    Username="barisscl",
                    CreatedAt=DateTime.UtcNow.ToTimeZone(),
                    IsDeleted=false
                },
                new User
                {
                    Id = 2, 
                    Name="Hakan",
                    Surname="Temiz",
                    RoleId=3,
                    Age=21,
                    BirthDate=DateTimeKind.Utc,
                    Email="hakantemiz@gmail.com",
                    Gender="Erkek",
                    Password="hakan.123H",
                    PhoneNumber="053087347821",
                    Username="hakaaannn.11",
                    CreatedAt=DateTime.UtcNow.ToTimeZone(),
                    IsDeleted=false
                }
            };
            builder.HasData(data);
        }
    }
}
