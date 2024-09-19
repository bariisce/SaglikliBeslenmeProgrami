using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class DietitianResponseDto
    {
        public int Id { get; set; } = default!;
        public UserResponseDto UserResponseDto { get; set; } = default!;
        public string LicenseNumber { get; set; } = default!;
        public string Specialization { get; set; } = default!;
    }
}
