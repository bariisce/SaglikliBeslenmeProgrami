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
        CreateMap<Allergy, AllergyResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<AllergyCreateDto, Allergy>();   // AdminCreateDTO -> Admin mapping
        CreateMap<AllergyUpdateDto, Allergy>();

        CreateMap<Role, RoleResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<RoleCreateDto, Role>();   // AdminCreateDTO -> Admin mapping
        CreateMap<RoleUpdateDto, Role>();

        CreateMap<User, UserResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<UserCreateDto, User>();   // AdminCreateDTO -> Admin mapping
        CreateMap<UserUpdateDto, User>();

        CreateMap<Patient, PatientResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<PatientCreateDto, Patient>();   // AdminCreateDTO -> Admin mapping
        CreateMap<PatientUpdateDto, Patient>();

        CreateMap<Dietitian, DietitianResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<DietitianCreateDto, Dietitian>();   // AdminCreateDTO -> Admin mapping
        CreateMap<DietitianUpdateDto, Dietitian>();

        CreateMap<DietitianPatient, DietitianPatientResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<DietitianPatientCreateDto, DietitianPatient>();   // AdminCreateDTO -> Admin mapping
        CreateMap<DietitianPatientUpdateDto, DietitianPatient>();

        CreateMap<PatientAllergy, PatientAllergyResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<PatientAllergyCreateDto, PatientAllergy>();   // AdminCreateDTO -> Admin mapping
        CreateMap<PatientAllergyUpdateDto, PatientAllergy>();

        CreateMap<Meal, MealResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<MealCreateDto, Meal>();   // AdminCreateDTO -> Admin mapping
        CreateMap<MealUpdateDto, Meal>();

        CreateMap<MealCategory, MealCategoryResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<MealCategoryCreateDto, MealCategory>();   // AdminCreateDTO -> Admin mapping
        CreateMap<MealCategoryUpdateDto, MealCategory>();

        CreateMap<DietPlan, DietPlanResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<DietPlanCreateDto, DietPlan>();   // AdminCreateDTO -> Admin mapping
        CreateMap<DietPlanUpdateDto, DietPlan>();

        CreateMap<DietPlanMeal, DietPlanMealResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<DietPlanMealCreateDto, DietPlanMeal>();   // AdminCreateDTO -> Admin mapping
        CreateMap<DietPlanMealUpdateDto, DietPlanMeal>();

        CreateMap<HealthRecord, HealthRecordResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<HealthRecordCreateDto, HealthRecord>();   // AdminCreateDTO -> Admin mapping
        CreateMap<HealthRecordUpdateDto, HealthRecord>();

        CreateMap<MealRecipe, MealRecipeResponseDto>(); // Admin -> AdminResponseDTO mapping
        CreateMap<MealRecipeCreateDto, MealRecipe>();   // AdminCreateDTO -> Admin mapping
        CreateMap<MealRecipeUpdateDto, MealRecipe>();
    }
}