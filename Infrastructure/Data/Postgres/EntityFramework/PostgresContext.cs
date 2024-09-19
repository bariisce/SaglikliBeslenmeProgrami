using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework
{
    public class PostgresContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration ) : base( options )
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AllergyConfiguration());
            modelBuilder.ApplyConfiguration(new DietitianConfiguration());
            modelBuilder.ApplyConfiguration(new DietitianPatientConfiguration());
            modelBuilder.ApplyConfiguration(new DietPlanConfiguration());
            modelBuilder.ApplyConfiguration(new DietPlanMealConfiguration());
            modelBuilder.ApplyConfiguration(new HealthRecordConfiguration());
            modelBuilder.ApplyConfiguration(new MealCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
            modelBuilder.ApplyConfiguration(new MealRecipeConfiguration());
            modelBuilder.ApplyConfiguration(new PatientAllergyConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (_configuration["EnviromentAlias"] == "DEV")
            {
                optionsBuilder.LogTo(Console.Write);
            }
        }

        public DbSet<Allergy> Allergies => Set<Allergy>();
        public DbSet<Dietitian> Dietitians => Set<Dietitian>();
        public DbSet<DietitianPatient> DietitianPatients => Set<DietitianPatient>();
        public DbSet<DietPlan> DietPlans => Set<DietPlan>();
        public DbSet<DietPlanMeal> DietPlanMeals => Set<DietPlanMeal>();
        public DbSet<HealthRecord> HealthRecords => Set<HealthRecord>();
        public DbSet<MealCategory> MealCategories => Set<MealCategory>();
        public DbSet<Meal> Meals => Set<Meal>();
        public DbSet<MealRecipe> MealRecipes => Set<MealRecipe>();
        public DbSet<PatientAllergy> PatientAllergies => Set<PatientAllergy>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<User> Users => Set<User>();
    }
}
