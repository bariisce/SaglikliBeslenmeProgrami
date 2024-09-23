namespace Business.Models.Request.Create
{
    public class DietitianCreateDto
    {
        public int UserId { get; set; }             = default!;
        public string Specialization { get; set; } = default!;
    }
}
