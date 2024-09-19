﻿using Business.Models.Request.Create;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DietitianController : BaseCRUDController<Dietitian, int, DietitianCreateDTO, DietitianUpdateDTO, DietitianResponseDTO>
    {
        public DietitianController(IDietitianService service) : base(service)
        {

        }
    }
}