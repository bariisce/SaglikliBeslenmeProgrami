﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MealRecipeResponseDto
    {
        public DietPlanResponseDto DietPlanResponseDto { get; set; } = default!;
        public MealResponseDto MealResponseDto { get; set; } = default!;
        public int Id { get; set; } = default!;
        public string Ingredients { get; set; } = default!;
        public string Instructions { get; set; } = default!;
    }
}