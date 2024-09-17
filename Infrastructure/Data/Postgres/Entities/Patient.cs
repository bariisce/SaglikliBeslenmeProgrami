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
        public int UserId { get; set; }                                      = default!;
        public float Weight { get; set; }                                    = default!;
        public float Height { get; set; }                                    = default!;
        public string MedicalConditions { get; set; }                        = default!;
        public string Medications { get; set; }                              = default!;
                                                                            
                                                                         
        public User Users { get; set; }                                      = default!;
        public ICollection<HealthRecord> HealthRecords { get; set; }         = default!;
        public ICollection<PatientAllergy> PatientAllergies { get; set; }    = default!;
        public ICollection<DietitianPatient> DietitianPatients { get; set; } = default!;
    }
}
