using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MealRecipe : Entity<int>
    {
        public int MealId { get; set; }          = default!;
        public string Ingredients { get; set; }  = default!;
        public string Instructions { get; set; } = default!;
        public string PreparationTime { get; set; } = default!;
        public string CookingTime { get; set; } = default!;

        public Meal Meal { get; set; } = default!;


    }
}
