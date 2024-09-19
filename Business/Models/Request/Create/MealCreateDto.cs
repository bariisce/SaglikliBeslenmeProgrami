using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class MealCreateDto
    {
        public int CategoryId { get; set; } = default!;
        public string MealName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Calory { get; set; } = default!;

    }
}
