using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Botanical:Courses
    {
        public List<Plants> FirstTermPlants { get; set; }
        public List<Plants> SecondTermPlants { get; set; }
        public List<Plants> ThirdTermPlants { get; set;}
        public List<Plants> FourthTermsPlants { get; set; }

    }
}
