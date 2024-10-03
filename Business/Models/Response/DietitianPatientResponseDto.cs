using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietitianPatientResponseDto
    {
        public DietitianResponseDto GetDietitian { get; set; } = default!;
        public PatientResponseDto GetPatient { get; set; } = default!;
        public DietPlanResponseDto GetDietPlan { get; set; } = default!;
        public int Id { get; set; } = default!;
    }
}
