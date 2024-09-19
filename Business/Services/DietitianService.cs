using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services
{
    public abstract class DietitianService : BaseService<Dietitian, int, DietitianResponseDto>,IDietitianService
    {
        public DietitianService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DietitianRepository, mapperHelper)
        {

        }
    }
}
