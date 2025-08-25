using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data.Models
{
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
