using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRateBouns { get; set; } = 0;

        public int Dept_ID { get; set; }
        public Department Department { get; set; } = null!;
    }
}
