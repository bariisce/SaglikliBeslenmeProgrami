﻿using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public abstract class DietitianPatientService : BaseService<DietitianPatient, int, DietitianPatientResponseDTO>, IDietitianPatientService
    {
        public DietitianPatientService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.DietitianPatientRepository, mapperHelper)
        {

        }
    }
}