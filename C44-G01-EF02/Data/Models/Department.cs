using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public DateTime HiringDate { get; set; }

        public int? Ins_ID { get; set; }
        public Instructor? Head { get; set; }

    }
}
