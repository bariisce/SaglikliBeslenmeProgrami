using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class User : Entity<int>
    {
        public string Name { get; set; }                   = default!;
        public string Surname { get; set; }                = default!;
        public string Email { get; set; }                  = default!;
        public string PhoneNumber { get; set; }            = default!;
        public string Username { get; set; }               = default!;
        public string Password { get; set; }               = default!;
        public string Gender { get; set; }                 = default!;
        public int Age { get; set; }                       = default!;
        public int RoleId { get; set; }                    = default!;


        public Role Roles { get; set; }                    = default!;
        public ICollection<Patient> Patients { get; set; } = default!;
        public ICollection<Dietitian> Dietitians { get; set; } = default!;



    }
}
