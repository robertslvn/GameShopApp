﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Game> GamesOfTheWeek { get; set; }
    }
}
