using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Allergy : Entity<int>
    {
        public string AllergyName { get; set; }
        public string Description { get; set; }

        public ICollection<PatientAllergy> PatientAllergies { get; set; }
    }
}
