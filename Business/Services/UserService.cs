﻿using Business.Models.Response;
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
    public abstract class UserService : BaseService<User, int, UserResponseDto>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper)
            : base(unitOfWork, unitOfWork.UserRepository, mapperHelper)
        {

        }
    }
}
