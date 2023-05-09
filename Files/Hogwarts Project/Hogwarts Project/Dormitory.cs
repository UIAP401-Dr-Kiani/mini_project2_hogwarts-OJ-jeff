using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public sealed class Dormitory
    {
       
        public string Group { get; set; }
        public int Floor { get; set; }
        public int RoomNumber { get; set; }
        public int BedNumber { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public static int TotalFloors { get; } = 4;
        public static int RoomsPerFloor { get; } = 5;
        public static int BedsPerRoom { get; } = 3;
        

    }
}
