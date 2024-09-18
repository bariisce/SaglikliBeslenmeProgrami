using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;
public interface IUnitOfWork : IDisposable
{
    IAllergyRepository Allergies { get; }
    IDietitianPatientRepository DietitianPatients { get; }
    IDietitianRepository Dietitians { get; }
    IDietPlanMealRepository DietPlanMeals { get; }
    IDietPlanRepository DietPlans { get; }
    IHealthRecordRepository HealthRecords { get; }
    IMealCategoryRepository MealCategories { get; }
    IMealRecipeRepository MealRecipes { get; }
    IMealRepository Meals { get; }
    IPatientAllergyRepository PatientAllergies { get; }
    IPatientRepository Patients { get; }
    IRoleRepository Roles { get; }
    IUserRepository Users { get; }
    Task<int> CommitAsync();
}
