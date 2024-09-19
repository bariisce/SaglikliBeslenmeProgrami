using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;
public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;
    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }
    private AllergyRepository? _allergyRepository;
    private DietitianPatientRepository? _dietitianPatientRepository;
    private DietitianRepository? _dietitianRepository;
    private DietPlanMealRepository? _dietPlanMealRepository;
    private DietPlanRepository? _dietPlanRepository;
    private HealthRecordRepository? _healthRecordRepository;
    private MealCategoryRepository? _mealCategoryRepository;
    private MealRecipeRepository? _mealRecipeRepository;
    private MealRepository? _mealRepository;
    private PatientAllergyRepository? _patientAllergyRepository;
    private PatientRepository? _patientRepository;
    private RoleRepository? _roleRepository;
    private UserRepository? _userRepository;
    
    public IAllergyRepository Allergies => _allergyRepository ??=
        new AllergyRepository(_postgresContext);
    public IDietitianPatientRepository DietitianPatients => _dietitianPatientRepository ??=
        new DietitianPatientRepository(_postgresContext);
    public IDietitianRepository Dietitians => _dietitianRepository ??=
        new DietitianRepository(_postgresContext);
    public IDietPlanMealRepository DietPlanMeals => _dietPlanMealRepository ??=
        new DietPlanMealRepository(_postgresContext);
    public IDietPlanRepository DietPlans => _dietPlanRepository ??=
        new DietPlanRepository(_postgresContext);
    public IHealthRecordRepository HealthRecords => _healthRecordRepository ??=
        new HealthRecordRepository(_postgresContext);
    public IMealCategoryRepository MealCategories => _mealCategoryRepository ??=
        new MealCategoryRepository(_postgresContext);
    public IMealRecipeRepository MealRecipes => _mealRecipeRepository ??=
        new MealRecipeRepository(_postgresContext);
    public IMealRepository Meals => _mealRepository ??=
        new MealRepository(_postgresContext);
    public IPatientAllergyRepository PatientAllergies => _patientAllergyRepository ??=
        new PatientAllergyRepository(_postgresContext);
    public IPatientRepository Patients => _patientRepository ??=
        new PatientRepository(_postgresContext);
    public IRoleRepository Roles => _roleRepository ??=
        new RoleRepository(_postgresContext);
    public IUserRepository Users => _userRepository ??=
        new UserRepository(_postgresContext);
    
    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);
        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToLocalTime();
        }
        var result = await _postgresContext.SaveChangesAsync();
        
        return result;
    }
    public void Dispose()
    {
        _postgresContext.Dispose();
    }
    
}

