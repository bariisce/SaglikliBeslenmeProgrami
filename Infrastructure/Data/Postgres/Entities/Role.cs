using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Role : Entity<int>
    {
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
