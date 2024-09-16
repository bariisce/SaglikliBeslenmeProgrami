using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Patient : Entity<int>
    {
        public int UserId { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string MedicalConditions { get; set; }
        public string Medications { get; set; }


        public Users Users { get; set; }
        public ICollection<HealthRecord> HealthRecords { get; set; }
        public ICollection<PatientAllergy> PatientAllergies { get; set; }
        public ICollection<DietitianPatient> DietitianPatients { get; set; }
    }
}
