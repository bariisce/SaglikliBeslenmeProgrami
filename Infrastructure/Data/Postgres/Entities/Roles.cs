using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Roles : Entity<int>
    {
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
