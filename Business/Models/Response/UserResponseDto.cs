using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class UserResponseDto
    {
        public RoleResponseDto RoleResponseDto { get; set; } = default!;

        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string BirthDate { get; set; } = default!;
        public string Gender { get; set; } = default!;
        public int Age { get; set; } = default!;
    }
}
