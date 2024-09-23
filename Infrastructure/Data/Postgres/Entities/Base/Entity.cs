using Infrastructure.Data.Postgres.Entities.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities;

namespace Infrastructure.Data.Postgres.Entities.Base
{
    public class Entity<T> : IEntity
    {
        public T Id { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        protected Entity()
        {
            CreatedAt = DateTime.UtcNow.ToTimeZone();
            IsDeleted = false;
        }
    }
}
