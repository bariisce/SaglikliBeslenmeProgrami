using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class HealthRecord : Entity<int>
    {
        public int PatientId { get; set; }          = default!;
        public decimal BloodPressure { get; set; }  = default!;
        public decimal HeartRate { get; set; }      = default!;
        public decimal Cholesterol { get; set; }    = default!;
        public decimal BloodSugar { get; set; }     = default!;
        public DateTime RecordedDate { get; set; }  = default!;

        public Patient Patient { get; set; } = default!;
    }
}
