using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PatientAllergyResponseDTO
    {
        public PatientResponseDTO PatientResponseDTO { get; set; } = default!;
        public AllergyResponseDTO AllergyResponseDTO { get; set; } = default!;
        public int Id { get; set; } = default!;
        public string Severity { get; set; } = default!;
        public string ReactionDescription { get; set; } = default!;
    }
}
