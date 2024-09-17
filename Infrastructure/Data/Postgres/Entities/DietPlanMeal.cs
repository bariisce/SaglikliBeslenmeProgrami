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
        public int DietPlanId { get; set; }    = default!;
        public int MealId { get; set; }        = default!;
        public float ServingSize { get; set; } = default!;
                                               
        public DietPlan DietPlan { get; set; } = default!;
        public Meal Meal { get; set; } = default!;
    }
}
