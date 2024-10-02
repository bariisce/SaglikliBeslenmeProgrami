﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MealResponseDto
    {
        public MealCategoryResponseDto MealCategoryResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
        public string MealName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Calory { get; set; } = default!;
        public string Image { get; set; } = default!;
        public double Protein { get; set; } = default!;
        public double Carbonhydrate { get; set; } = default!;
        public double Fat { get; set; } = default!;
    }
}
