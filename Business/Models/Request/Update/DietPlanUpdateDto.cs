using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class DietPlanUpdateDto
    {
        public int DietitianId { get; set; } = default!;
        public int PatientId { get; set; } = default!;
        public string DietPlanName { get; set; } = default!;
        public string StartDate { get; set; } = default!;
        public string EndDate { get; set; } = default!;
        public int CaloriesPerDay { get; set; } = default!;
        public bool Status { get; set; } = true;
        public string Details { get; set; } = default!;
    }
}
