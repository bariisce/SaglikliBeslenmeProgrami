using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class AllergyCreateDTO
    {
        public string AllergyName { get; set; } = default!;
        public string Description { get; set; } = default!;

    }
}
