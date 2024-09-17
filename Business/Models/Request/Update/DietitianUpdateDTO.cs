using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class DietitianDTO
    {
        public int UserId { get; set; } = default!;
        public string LicenseNumber { get; set; } = default!;
        public string Specialization { get; set; } = default!;
    }
}
