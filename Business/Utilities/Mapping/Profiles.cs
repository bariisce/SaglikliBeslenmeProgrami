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

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<Allergy, AllergyResponseDto>(); 
        CreateMap<AllergyCreateDto, Allergy>();   
        CreateMap<AllergyUpdateDto, Allergy>();

        CreateMap<Role, RoleResponseDto>(); 
        CreateMap<RoleCreateDto, Role>();   
        CreateMap<RoleUpdateDto, Role>();

        CreateMap<User, UserResponseDto>(); 
        CreateMap<UserCreateDto, User>();   
        CreateMap<UserUpdateDto, User>();

        CreateMap<Patient, PatientResponseDto>(); 
        CreateMap<PatientCreateDto, Patient>();   
        CreateMap<PatientUpdateDto, Patient>();

        CreateMap<Dietitian, DietitianResponseDto>(); 
        CreateMap<DietitianCreateDto, Dietitian>();   
        CreateMap<DietitianUpdateDto, Dietitian>();

        CreateMap<DietitianPatient, DietitianPatientResponseDto>(); 
        CreateMap<DietitianPatientCreateDto, DietitianPatient>();   
        CreateMap<DietitianPatientUpdateDto, DietitianPatient>();

        CreateMap<PatientAllergy, PatientAllergyResponseDto>(); 
        CreateMap<PatientAllergyCreateDto, PatientAllergy>();   
        CreateMap<PatientAllergyUpdateDto, PatientAllergy>();

        CreateMap<Meal, MealResponseDto>(); 
        CreateMap<MealCreateDto, Meal>();   
        CreateMap<MealUpdateDto, Meal>();

        CreateMap<MealCategory, MealCategoryResponseDto>(); 
        CreateMap<MealCategoryCreateDto, MealCategory>();   
        CreateMap<MealCategoryUpdateDto, MealCategory>();

        CreateMap<DietPlan, DietPlanResponseDto>(); 
        CreateMap<DietPlanCreateDto, DietPlan>();   
        CreateMap<DietPlanUpdateDto, DietPlan>();

        CreateMap<DietPlanMeal, DietPlanMealResponseDto>(); 
        CreateMap<DietPlanMealCreateDto, DietPlanMeal>();   
        CreateMap<DietPlanMealUpdateDto, DietPlanMeal>();

        CreateMap<HealthRecord, HealthRecordResponseDto>(); 
        CreateMap<HealthRecordCreateDto, HealthRecord>();   
        CreateMap<HealthRecordUpdateDto, HealthRecord>();

        CreateMap<MealRecipe, MealRecipeResponseDto>(); 
        CreateMap<MealRecipeCreateDto, MealRecipe>();   
        CreateMap<MealRecipeUpdateDto, MealRecipe>();
    }
}