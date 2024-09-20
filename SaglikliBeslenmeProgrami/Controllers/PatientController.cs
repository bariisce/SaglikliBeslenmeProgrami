using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class PatientController : BaseCrudController<Patient, int, PatientCreateDto, PatientUpdateDto, PatientResponseDto>
    {
        public PatientController(IPatientService service) : base(service)
        {
            
        }
    }
}
