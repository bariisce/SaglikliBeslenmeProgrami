using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class HealthRecordResponseDto
    {
        public PatientResponseDto GetPatient { get; set; } = default!;
        public int Id { get; set; } = default!;
        public decimal BloodPressure { get; set; } = default!;
        public decimal HeartRate { get; set; } = default!;
        public decimal Cholesterol { get; set; } = default!;
        public decimal BloodSugar { get; set; } = default!;
        public string RecordedDate { get; set; } = default!;
    }
}
