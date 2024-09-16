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
        public int DietitianId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CaloriesPerDay { get; set; }
        public string Details { get; set; }

        public Dietitian Dietitian { get; set; }
        public Patient Patient { get; set; }
        public ICollection<DietPlanMeal> DietPlanMeals { get; set; }
    }
}
