using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Tsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Utilities.Mapping
{
    public class Profiles : AutoMapper.Profile
    {
        public Profiles()
        {
            CreateMap<AllergyCreateDTO, Allergy>();
            CreateMap<RoleCreateDTO, Role>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<PatientCreateDTO, Patient>();
            CreateMap<DietitianCreateDTO, Dietitian>();
            CreateMap<DietPlanCreateDTO, DietPlan>();
            CreateMap<DietitianPatientCreateDTO, DietitianPatient>();
            CreateMap<PatientAllergyCreateDTO, PatientAllergy>();
            CreateMap<MealCategoryCreateDTO, MealCategory>();
            CreateMap<MealCreateDTO, Meal>();
            CreateMap<MealRecipeCreateDTO, MealRecipe>();
            CreateMap<HealthRecordCreateDTO, HealthRecord>();
            CreateMap<DietPlanMealCreateDTO, DietPlanMeal>();

            CreateMap<AllergyUpdateDTO, Allergy>();
            CreateMap<RoleUpdateDTO, Role>();
            CreateMap<UserUpdateDTO, User>();
            CreateMap<DietitianUpdateDTO, Dietitian>();
            CreateMap<PatientUpdateDTO, Patient>();
            CreateMap<DietitianPatientUpdateDTO, DietitianPatient>();
            CreateMap<PatientAllergyUpdateDTO, PatientAllergy>();
            CreateMap<MealCategoryUpdateDTO, MealCategory>();
            CreateMap<MealUpdateDTO, Meal>();
            CreateMap<MealRecipeUpdateDTO, MealRecipe>();
            CreateMap<DietPlanUpdateDTO, DietPlan>();
            CreateMap<DietPlanMealUpdateDTO, DietPlanMeal>();
            CreateMap<HealthRecordUpdateDTO, HealthRecord>();

            CreateMap<AllergyResponseDTO, Allergy>();
            CreateMap<RoleResponseDTO, Role>();
            CreateMap<UserResponseDTO, User>();
            CreateMap<DietitianResponseDTO, Dietitian>();
            CreateMap<PatientResponseDTO, Patient>();
            CreateMap<DietitianPatientResponseDTO, DietitianPatient>();
            CreateMap<PatientAllergyResponseDTO, PatientAllergy>();
            CreateMap<MealCategoryResponseDTO, MealCategory>();
            CreateMap<MealResponseDTO, Meal>();
            CreateMap<MealRecipeResponseDTO, MealRecipe>();
            CreateMap<DietPlanResponseDTO, DietPlan>();
            CreateMap<DietPlanMealResponseDTO, DietPlanMeal>();
            CreateMap<HealthRecordResponseDTO, HealthRecord>();
        }
    }
}