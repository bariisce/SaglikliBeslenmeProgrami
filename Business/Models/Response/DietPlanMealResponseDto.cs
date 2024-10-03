using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietPlanMealResponseDto
    {
        public DietPlanResponseDto GetDietPlan { get; set; } = default!;
        public MealResponseDto GetMeal { get; set; } = default!;
        public int Id { get; set; } = default!;
        public int ServingSize { get; set; } = default!;
    }
}
