using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Botanical:Courses
    {
        public Botanical()
        {
            Botanical.FirstTermPlants = new List<Plants>();
            Botanical.SecondTermPlants = new List<Plants>();
            Botanical.ThirdTermPlants = new List<Plants>();
            Botanical.FourthTermsPlants = new List<Plants>();
            FirstTermPlants.Add(new Plants() { Name="plant11"});
            FirstTermPlants.Add(new Plants() { Name = "plant12" });
            SecondTermPlants.Add(new Plants() { Name = "plant21" });
            SecondTermPlants.Add(new Plants() { Name="plant22"});
            ThirdTermPlants.Add(new Plants() { Name = "plant31" });
            ThirdTermPlants.Add(new Plants() { Name = "plant32" });
            FourthTermsPlants.Add(new Plants() { Name = "plant41" });
            FourthTermsPlants.Add(new Plants() { Name = "plant42" });

        }
        public static List<Plants> FirstTermPlants { get; set; }
        public static List<Plants> SecondTermPlants { get; set; }
        public static List<Plants> ThirdTermPlants { get; set;}
        public static List<Plants> FourthTermsPlants { get; set; }

    }
}
