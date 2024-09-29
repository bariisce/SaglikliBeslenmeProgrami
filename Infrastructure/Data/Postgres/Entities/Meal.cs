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
        public int CategoryId { get; set; }                          = default!;
        public string MealName { get; set; }                         = default!;
        public string Description { get; set; }                      = default!;
        public decimal Calory { get; set; }                          = default!;
        public string Image { get; set; } = default!;
                                                                     
                                                                    
        public MealCategory Category { get; set; }                   = default!;
        public ICollection<DietPlanMeal> DietPlanMeals { get; set; } = default!;

    }
}
