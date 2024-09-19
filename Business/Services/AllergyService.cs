using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services.Base;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;


namespace Business.Services
{
    public class AllergyService : BaseService<Allergy, int, AllergyResponseDto>,IAllergyService
    {
        public AllergyService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) 
            : base(unitOfWork, unitOfWork.Allergies, mapperHelper)
        {

        }
    }
}
