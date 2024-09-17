using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietitianPatientResponseDTO
    {
        public DietitianResponseDTO DietitianResponseDTO { get; set; } = default!;
        public PatientResponseDTO PatientResponseDTO { get; set; } = default!;
        public DietPlanResponseDTO DietPlanResponseDTO { get; set; } = default!;
        public int Id { get; set; } = default!;
    }
}
