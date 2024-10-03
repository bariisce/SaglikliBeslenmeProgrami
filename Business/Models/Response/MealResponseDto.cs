using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MealResponseDto
    {
        public MealCategoryResponseDto GetMealCategory { get; set; } = default!;
        public int Id { get; set; } = default!;
        public string MealName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Calory { get; set; } = default!;
        public string Image { get; set; } = default!;
        public string Protein { get; set; } = default!;
        public string Carbonhydrate { get; set; } = default!;
        public string Fat { get; set; } = default!;
    }
}
