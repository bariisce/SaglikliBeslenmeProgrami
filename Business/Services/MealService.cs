using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services.Base;
using Business.Utilities.Mapping.Interface;

namespace Business.Services
{
    public abstract class MealService : BaseService<Meal, int, MealResponseDto>, IMealService
    {
        public MealService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.MealRepository, mapperHelper)
        {

        }
    }
}
