using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DietPlan : Entity<int>
    {
        public int DietitianId { get; set; }                            = default!;
        public int PatientId { get; set; }                              = default!;
        public string StartDate { get; set; }                         = default!;
        public string EndDate { get; set; }                           = default!;
        public int CaloriesPerDay { get; set; }                         = default!;
        public string Details { get; set; }                             = default!;
                                                                        
        public Dietitian Dietitian { get; set; }                        = default!;
        public Patient Patient { get; set; }                            = default!;
        public ICollection<DietPlanMeal> DietPlanMeals { get; set; } = default!;
    }
}
