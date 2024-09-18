using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres.Repositories
{

    public class DietPlanRepository : Repository<DietPlan, int>, IDietPlanRepository
    {
        public DietPlanRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }
    }
}