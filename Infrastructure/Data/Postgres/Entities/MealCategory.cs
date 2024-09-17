﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MealCategory : Entity<int>
    {
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = default!;

    }
}
