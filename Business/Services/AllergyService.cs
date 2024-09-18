using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base
{
    public class AllergyService : BaseService<Allergy, int, AllergyResponseDTO>,IAllergyService
    {
        public AllergyService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) 
            : base(unitOfWork, unitOfWork.AllergyRepository, mapperHelper)
        {

        }
    }
}
