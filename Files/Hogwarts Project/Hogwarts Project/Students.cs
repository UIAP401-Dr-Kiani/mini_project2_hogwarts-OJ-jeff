using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Students:People
    {
        public List<string> PassedCourses { get; set; }
        public int Term { get; set; }
        public int DormitoryNumber { get; set; }
    }
}
