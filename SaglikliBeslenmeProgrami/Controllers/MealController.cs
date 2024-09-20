using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class MealController : BaseCrudController<Meal, int, MealCreateDto, MealUpdateDto, MealResponseDto>
    {
        public MealController(IMealService service) : base(service)
        {
            
        }
    }
}
