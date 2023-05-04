using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string Gender { get; set; }
        public string Father { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public BloodType TypeOfBlood { get; set; }

        public enum BloodType
        {
            HalfBlood,
            PureBlood,
            MuggleBlood
        }
    }
}
