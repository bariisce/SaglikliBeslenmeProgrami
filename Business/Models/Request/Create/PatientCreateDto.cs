using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class PatientCreateDto
    {
        public int UserId { get; set; } = default!;
        public float Weight { get; set; } = default!;
        public float Height { get; set; } = default!;
        public string MedicalConditions { get; set; } = default!;
        public string Medications { get; set; } = default!;
    }
}
