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
        public int PatientId { get; set; }
        public int AllergyId { get; set; }
        public string Severity { get; set; }
        public string ReactionDescription { get; set; }

        public Patient Patient { get; set; }
        public Allergy Allergy { get; set; }
    }
}
