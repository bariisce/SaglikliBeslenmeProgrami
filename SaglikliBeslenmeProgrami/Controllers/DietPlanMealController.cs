﻿using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DietPlanMealController : BaseCrudController<DietPlanMeal, int, DietPlanMealCreateDto, DietPlanMealUpdateDto, DietPlanMealResponseDto>
    {
        public DietPlanMealController(IDietPlanMealService service) : base(service)
        {
            
        }
    }
}
