using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class DietPlanCreateDto
    {
        public int DietitianId { get; set; } = default!;
        public int PatientId { get; set; } = default!;
        public DateTimeKind StartDate { get; set; } = default!;
        public DateTimeKind EndDate { get; set; } = default!;
        public int CaloriesPerDay { get; set; } = default!;
        public string Details { get; set; } = default!;
    }
}
