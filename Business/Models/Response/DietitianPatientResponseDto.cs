using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietitianPatientResponseDto
    {
        public DietitianResponseDto DietitianResponseDto { get; set; } = default!;
        public PatientResponseDto PatientResponseDto { get; set; } = default!;
        public DietPlanResponseDto DietPlanResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
    }
}
