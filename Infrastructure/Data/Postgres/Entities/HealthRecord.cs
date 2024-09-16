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
        public int PatientId { get; set; }
        public decimal BloodPressure { get; set; }
        public decimal HeartRate { get; set; }
        public decimal Cholesterol { get; set; }
        public decimal BloodSugar { get; set; }
        public DateTime RecordedDate { get; set; }
        
        public Patient Patient { get; set; }
    }
}
