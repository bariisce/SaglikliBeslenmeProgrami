namespace Business.Models.Request.Update
{
    public class DietitianUpdateDto
    {
        public int UserId { get; set; } = default!;
        public string Specialization { get; set; } = default!;
        public int ExperienceYears { get; set; } = default!;
        public bool IsActive { get; set; } = true;
    }
}
