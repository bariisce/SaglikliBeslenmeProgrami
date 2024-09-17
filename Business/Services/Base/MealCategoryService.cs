using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base
{
    public abstract class MealCategoryService : BaseService<MealCategory, int, MealCategoryResponseDTO>, IMealCategoryService
    {
        public MealCategoryService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.MealCategoryRepository, mapperHelper)
        {

        }
    }
}
