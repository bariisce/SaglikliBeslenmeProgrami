using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PatientResponseDto
    {
        public UserResponseDto GetUser { get; set; } = default!;
        public int Id { get; set; } = default!;
        public float Weight { get; set; } = default!;
        public float Height { get; set; } = default!;
        public string MedicalConditions { get; set; } = default!;
        public string Medications { get; set; } = default!;
    }
}
