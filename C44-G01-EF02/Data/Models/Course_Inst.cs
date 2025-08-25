using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Course_Inst
    {
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; } = null!;

        public int Course_ID { get; set; }
        public Course Course { get; set; } = null!;

        public int? Evaluate { get; set; }
    }
}
