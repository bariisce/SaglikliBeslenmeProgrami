﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class PatientAllergyCreateDTO
    {
        public int PatientId { get; set; } = default!;
        public int AllergyId { get; set; } = default!;
        public string Severity { get; set; } = default!;
        public string ReactionDescription { get; set; } = default!;
    }
}
