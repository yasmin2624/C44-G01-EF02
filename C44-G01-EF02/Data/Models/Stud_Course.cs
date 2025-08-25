using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Stud_Course
    {
        public int stud_ID { get; set; }
        public Student Student { get; set; } = null!;

        public int Course_ID { get; set; }
        public Course Course { get; set; } = null!;

        public int? Grade { get; set; }
    }
}
