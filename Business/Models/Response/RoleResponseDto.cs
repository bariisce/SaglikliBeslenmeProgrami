using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class RoleResponseDto
    {
        public int Id { get; set; } = default!;
        public string RoleName { get; set; } = default!;
    }
}
