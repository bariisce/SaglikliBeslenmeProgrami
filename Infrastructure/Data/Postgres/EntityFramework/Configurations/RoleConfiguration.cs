using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class RoleConfiguration : BaseConfiguration<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            var data = new Role[]
            {
                new Role{Id=1, RoleName="Admin", CreatedAt=DateTime.UtcNow.ToLocalTime(), IsDeleted=false},
                new Role{Id=2, RoleName="Dietitian", CreatedAt=DateTime.UtcNow.ToLocalTime(), IsDeleted=false},
                new Role{Id=3, RoleName="Patient", CreatedAt=DateTime.UtcNow.ToLocalTime(), IsDeleted=false},
            };
            builder.HasData(data);
        }
    }
}
