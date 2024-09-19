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
        CreateMap<AllergyCreateDto, Allergy>();
        CreateMap<RoleCreateDto, Role>();
        CreateMap<UserCreateDto, User>();
        CreateMap<PatientCreateDto, Patient>();
        CreateMap<DietitianCreateDto, Dietitian>();
        CreateMap<DietPlanCreateDto, DietPlan>();
        CreateMap<DietitianPatientCreateDto, DietitianPatient>();
        CreateMap<PatientAllergyCreateDto, PatientAllergy>();
        CreateMap<MealCategoryCreateDto, MealCategory>();
        CreateMap<MealCreateDto, Meal>();
        CreateMap<MealRecipeCreateDto, MealRecipe>();
        CreateMap<HealthRecordCreateDto, HealthRecord>();
        CreateMap<DietPlanMealCreateDto, DietPlanMeal>();

        CreateMap<AllergyUpdateDto, Allergy>();
        CreateMap<RoleUpdateDto, Role>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<DietitianUpdateDto, Dietitian>();
        CreateMap<PatientUpdateDto, Patient>();
        CreateMap<DietitianPatientUpdateDto, DietitianPatient>();
        CreateMap<PatientAllergyUpdateDto, PatientAllergy>();
        CreateMap<MealCategoryUpdateDto, MealCategory>();
        CreateMap<MealUpdateDto, Meal>();
        CreateMap<MealRecipeUpdateDto, MealRecipe>();
        CreateMap<DietPlanUpdateDto, DietPlan>();
        CreateMap<DietPlanMealUpdateDto, DietPlanMeal>();
        CreateMap<HealthRecordUpdateDto, HealthRecord>();

        CreateMap<AllergyResponseDto, Allergy>();
        CreateMap<RoleResponseDto, Role>();
        CreateMap<UserResponseDto, User>();
        CreateMap<DietitianResponseDto, Dietitian>();
        CreateMap<PatientResponseDto, Patient>();
        CreateMap<DietitianPatientResponseDto, DietitianPatient>();
        CreateMap<PatientAllergyResponseDto, PatientAllergy>();
        CreateMap<MealCategoryResponseDto, MealCategory>();
        CreateMap<MealResponseDto, Meal>();
        CreateMap<MealRecipeResponseDto, MealRecipe>();
        CreateMap<DietPlanResponseDto, DietPlan>();
        CreateMap<DietPlanMealResponseDto, DietPlanMeal>(); 
        CreateMap<HealthRecordResponseDto, HealthRecord>();
    }
}
