﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApp.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Named { get; set; }
        public bool IsComplete { get; set; }
    }
}
