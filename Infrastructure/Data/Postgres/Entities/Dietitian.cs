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
        public int UserId { get; set; }             = default!;
        public string Specialization { get; set; } = default!;
        public int ExperienceYears { get; set; } = default!;
        public Boolean IsActive { get; set; } = true;

        public User Users { get; set; } = default!;
        public ICollection<DietitianPatient> DietitianPatients { get; set; } = default!;
        public ICollection<DietPlan> DietPlans { get; set; } = default!;
    }
}
