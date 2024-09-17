﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class HealthRecordUpdateDTO
    {
        public int PatientId { get; set; } = default!;
        public decimal BloodPressure { get; set; } = default!;
        public decimal HeartRate { get; set; } = default!;
        public decimal Cholesterol { get; set; } = default!;
        public decimal BloodSugar { get; set; } = default!;
        public DateTime RecordedDate { get; set; } = default!;
    }
}
