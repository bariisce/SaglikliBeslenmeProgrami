using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class DietitianPatientUpdateDto
    {
        public int DietitianId { get; set; } = default!;
        public int PatientId { get; set; } = default!;
        public int DietPlanId { get; set; } = default!;
    }
}
