using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietPlanMealResponseDTO
    {
        public DietPlanResponseDTO DietPlanResponseDTO { get; set; } = default!;
        public MealResponseDTO MealResponseDTO { get; set; } = default!;
        public int Id { get; set; } = default!;
        public float ServingSize { get; set; } = default!;
    }
}
