using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class MealRecipeUpdateDto
    {
        public int MealId { get; set; } = default!;
        public string Ingredients { get; set; } = default!;
        public string Instructions { get; set; } = default!;
        public string PreparationTime { get; set; } = default!;
        public string CookingTime { get; set; } = default!;

    }
}
