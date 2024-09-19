
using Business.Services;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interfaces;
using Infrastructure.Data.Postgres;
using System.Web.WebPages;

namespace Web.Utilities
{
    public static class DependencyInjection
    {
        public static void AddMyScoped(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAllergyService, AllergyService>();
            serviceCollection.AddScoped<IDietitianPatientService, DietitianPatientService>();
            serviceCollection.AddScoped<IDietitianService, DietitianService>();
            serviceCollection.AddScoped<IDietPlanMealService, DietPlanMealService>();
            serviceCollection.AddScoped<IDietPlanService, DietPlanService>();
            serviceCollection.AddScoped<IHealthRecordService, HealthRecordService>();
            serviceCollection.AddScoped<IMealCategoryService, MealCategoryService>();
            serviceCollection.AddScoped<IMealRecipeService, MealRecipeService>();
            serviceCollection.AddScoped<IMealService, MealService>();
            serviceCollection.AddScoped<IPatientAllergyService, PatientAllergyService>();
            serviceCollection.AddScoped<IPatientService, PatientService>();
            serviceCollection.AddScoped<IRoleService, RoleService>();
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void AddMySingleton(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
            serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
            serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
            serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
            serviceCollection.AddSingleton<IMailHelper, MailHelper>();
        }

        public static void AddMyTransient(this IServiceCollection serviceCollection)
        {
        }

    }
}
