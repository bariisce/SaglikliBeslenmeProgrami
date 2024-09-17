using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietPlanResponseDTO
    {
        public DietitianResponseDTO DietitianResponseDTO { get; set; } = default!;
        public PatientResponseDTO PatientResponseDTO { get; set; } = default!;
        public int Id { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public int CaloriesPerDay { get; set; } = default!;
        public string Details { get; set; } = default!;
    }
}
