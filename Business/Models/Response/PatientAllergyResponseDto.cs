using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PatientAllergyResponseDto
    {
        public PatientResponseDto PatientResponseDto { get; set; } = default!;
        public AllergyResponseDto AllergyResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
        public string Severity { get; set; } = default!;
        public string ReactionDescription { get; set; } = default!;
    }
}
