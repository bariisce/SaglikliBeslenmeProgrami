using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class DietPlanMealCreateDto
    {
        public int DietPlanId { get; set; } = default!;
        public int MealId { get; set; } = default!;
        public int ServingSize { get; set; } = default!;
    }
}
