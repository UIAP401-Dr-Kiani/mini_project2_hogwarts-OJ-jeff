using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Students:People
    {
        public Students() 
        {
            grade = 0;
        }
        public List<Courses> CurrentCourses { get; set; }
        public List<Courses> PassedCourses { get; set; }
        public int Term { get; set; }
        public int DormitoryNumber { get; set; }
        public bool IsInHogwarts { get; set; }
        public bool HasDoneBHomework { get; set; }
        public bool HasDoneCHomework { get;set; }
        public double grade { get; set; }

        
    }
}
