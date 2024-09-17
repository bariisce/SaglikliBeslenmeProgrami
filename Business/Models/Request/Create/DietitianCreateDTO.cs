using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DietitianCreateDTO
    {
        public int UserId { get; set; }             = default!;
        public string LicenseNumber { get; set; }   = default!;
        public string Specialization { get; set; } = default!;
    }
}
