using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Meal : Entity<int>
    {
        public int CategoryId { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public decimal Calory { get; set; }


        public MealCategories Category { get; set; }
        public ICollection<DietPlanMeal> DietPlanMeals { get; set; }

    }
}
