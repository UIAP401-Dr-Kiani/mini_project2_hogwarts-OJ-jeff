using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class People:Human
    {
        public int RoomNumber { get; set; }
        public string Curriculum { get; set; }
        public PetType Pet { get; set; }
        public GroupType Group { get; set; }
        public bool HasLuggage { get; set; } 
        public List<string> ReceivedLetters { get; set; }

        public enum PetType
        {
            None,
            Cat,
            Rat,
            Owl
        }



        
    }
}
