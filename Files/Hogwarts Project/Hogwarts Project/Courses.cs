using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Courses
    {
        public Courses() 
        {
           
        }
        public string Name { get; set; }
        public int Term { get; set; }
        public int Capacity { get; set; }
        public int NumberOfStudents { get; set; }
        public string Time { get; set; }
        public string Teacher { get; set; }
        public string Info { get; set; }
        public double Grade { get; set; }
        public static bool HasBHomework { get; set; }
        public static bool HasCHomework { get; set; }
        public static DateTime BHomeworkStartTime {  get; set; }
        public static DateTime BHomeworkFinishTime { get; set; }
        public static DateTime CHomeworkStartTime { get; set; }
        public static DateTime CHomeworkFinishTime { get; set; }

        public override string ToString() 
        {
            return $"Name : {this.Name} , Term : {this.Term} , Capacity : {this.Capacity} , Time : {this.Time} , Teacher : {this.Teacher}";

        }

    }
}
