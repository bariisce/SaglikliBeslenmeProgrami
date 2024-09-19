using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietPlanMealResponseDto
    {
        public DietPlanResponseDto DietPlanResponseDto { get; set; } = default!;
        public MealResponseDto MealResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
        public float ServingSize { get; set; } = default!;
    }
}
