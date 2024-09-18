using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class AllergyConfiguration : BaseConfiguration<Allergy, int>
    {
        public override void Configure(EntityTypeBuilder<Allergy> builder)
        {
            base.Configure(builder);

            var data = new Allergy[]
            {
                new Allergy{Id=1, AllergyName="İlaç Alerjisi", Description="Kaşıntı, Kurdeşen, Döküntü, Yüzün Şişmesi",  CreatedAt=DateTime.UtcNow.ToLocalTime(), IsDeleted=false},
            };
            builder.HasData(data);
        }
    }
}
