using Business.Models.Response;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interface
{
    public interface IDietitianService : IBaseService<Dietitian, int, DietitianResponseDTO>
    {
    }
}
