﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGroup.Data.Services
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CusineType Cuisine { get; set; }
    }
}
