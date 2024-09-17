using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class DietPlanMealUpdateDTO
    {
        public int DietPlanId { get; set; } = default!;
        public int MealId { get; set; } = default!;
        public float ServingSize { get; set; } = default!;
    }
}
