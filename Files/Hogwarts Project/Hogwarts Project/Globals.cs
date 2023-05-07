using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public class Globals
    {
        Human[] Humans = new Human[400];
        Jsonarray[] test = new Jsonarray[300];
        string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
    }
}
