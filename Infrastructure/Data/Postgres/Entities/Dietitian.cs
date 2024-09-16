using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Dietitian : Entity<int>
    {
        public int UserId { get; set; }
        public string LicenseNumber { get; set; }
        public string Specialization {  get; set; }

        public User Users { get; set; }
        public ICollection<DietitianPatient> DietitianPatients { get; set; }
        public ICollection<DietPlan> DietPlans { get; set; }
    }
}
