using Core.Utilities;
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
    
    public IAllergyRepository AllergyRepository => _allergyRepository ??=
        new AllergyRepository(_postgresContext);
    public IDietitianPatientRepository DietitianPatientRepository => _dietitianPatientRepository ??=
        new DietitianPatientRepository(_postgresContext);
    public IDietitianRepository DietitianRepository => _dietitianRepository ??=
        new DietitianRepository(_postgresContext);
    public IDietPlanMealRepository DietPlanMealRepository => _dietPlanMealRepository ??=
        new DietPlanMealRepository(_postgresContext);
    public IDietPlanRepository DietPlanRepository => _dietPlanRepository ??=
        new DietPlanRepository(_postgresContext);
    public IHealthRecordRepository HealthRecordRepository => _healthRecordRepository ??=
        new HealthRecordRepository(_postgresContext);
    public IMealCategoryRepository MealCategoryRepository => _mealCategoryRepository ??=
        new MealCategoryRepository(_postgresContext);
    public IMealRecipeRepository MealRecipeRepository => _mealRecipeRepository ??=
        new MealRecipeRepository(_postgresContext);
    public IMealRepository MealRepository => _mealRepository ??=
        new MealRepository(_postgresContext);
    public IPatientAllergyRepository PatientAllergyRepository => _patientAllergyRepository ??=
        new PatientAllergyRepository(_postgresContext);
    public IPatientRepository PatientRepository => _patientRepository ??=
        new PatientRepository(_postgresContext);
    public IRoleRepository RoleRepository => _roleRepository ??=
        new RoleRepository(_postgresContext);
    public IUserRepository UserRepository => _userRepository ??=
        new UserRepository(_postgresContext);
    
    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);
        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }
        var result = await _postgresContext.SaveChangesAsync();
        
        return result;
    }
    public void Dispose()
    {
        _postgresContext.Dispose();
    }
    
}

