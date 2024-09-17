using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class PatientAllergy : Entity<int>
    {
        public int PatientId { get; set; }               = default!;
        public int AllergyId { get; set; }               = default!;
        public string Severity { get; set; }             = default!;
        public string ReactionDescription { get; set; }  = default!;
                                                        
        public Patient Patient { get; set; }             = default!;
        public Allergy Allergy { get; set; } = default!;
    }
}
