using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class MealUpdateDto
    {
        public int CategoryId { get; set; } = default!;
        public string MealName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Calory { get; set; } = default!;

    }
}
