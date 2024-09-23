using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietPlanResponseDto
    {
        public DietitianResponseDto DietitianResponseDto { get; set; } = default!;
        public PatientResponseDto PatientResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
        public DateTimeKind StartDate { get; set; } = default!;
        public DateTimeKind EndDate { get; set; } = default!;
        public int CaloriesPerDay { get; set; } = default!;
        public string Details { get; set; } = default!;
    }
}
