using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DietPlanMeal : Entity<int>
    {
        public int DietPlanId { get; set; }
        public int MealId { get; set; }
        public float ServingSize { get; set; }

        public DietPlan DietPlan { get; set; }
        public Meal Meal { get; set; }
    }
}
