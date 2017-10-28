﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; } = string.Empty;
        public HashSet<Trick> Tricks { get; set; } = new HashSet<Trick>();
        public Food Food { get; set; } = Food.Chicken;
        public Drink Drink { get; set; } = Drink.Coke;
        public bool KnowsAnyTrick => Tricks.Count > 0;
    }
}
