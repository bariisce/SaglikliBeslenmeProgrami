﻿namespace Business.Models.Request.Create
{
    public class DietitianCreateDto
    {
        public int UserId { get; set; }             = default!;
        public string Specialization { get; set; } = default!;
        public int ExperienceYears { get; set; } = default!;
        public bool IsActive { get; set; } = true;
    }
}
