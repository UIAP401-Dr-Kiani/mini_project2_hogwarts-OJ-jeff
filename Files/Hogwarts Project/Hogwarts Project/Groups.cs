using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{



    public class Group
    {
        public GroupType Type { get; set; }
        public int Score { get; set; }
        public List<People> Members { get; set; }
        public List<People> QuidditchPlayers { get; set; }

    }
}
 
