using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class AllergyController : BaseCrudController<Allergy, int, AllergyCreateDto, AllergyUpdateDto, AllergyResponseDto>
    {
        public AllergyController(IAllergyService service) : base(service)
        {
            
        }
    }
}
