using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DietitianPatient : Entity<int>
    {
        public int DietitianId { get; set; }
        public int PatientId { get; set; }
        public int DietPlanId { get; set; }

        public Dietitian Dietitian { get; set; }
        public Patient Patient { get; set; }
        public DietPlan DietPlan { get; set; }
    }
}
