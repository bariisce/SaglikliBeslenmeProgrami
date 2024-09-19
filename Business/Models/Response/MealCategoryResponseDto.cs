﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MealCategoryResponseDto
    {
        public int Id { get; set; } = default!;
        public string CategoryName { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}