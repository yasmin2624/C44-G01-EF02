using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string? Address { get; set; }
        public int Age { get; set; }

        public int Dep_Id { get; set; }
        public Department Department { get; set; } = null!;

    }
}
