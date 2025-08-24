﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public int Top_ID { get; set; }
        public Topic Topic { get; set; } = null!;
    }
}
