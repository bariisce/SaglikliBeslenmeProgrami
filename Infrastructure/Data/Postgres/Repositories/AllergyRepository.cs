using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class AllergyRepository : Repository<Allergy, int>, IAllergyRepository
    {
        public AllergyRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }
    }
}
