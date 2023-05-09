using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public sealed class Globals
    {
        public Globals() 
        {
            PeopleSort();
            StudentSort();
            DormFix();
        }
        private static Globals instance = null;
        private static readonly object padlock = new object();
        public Human[] Humans = new Human[400];
        public Students[] Student = new Students[400];
        
        public Jsonarray[] test = new Jsonarray[300];
        public string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
        public Dormitory[] GryffindorDorm = new Dormitory[60];
        public Dormitory[] HufflepuffDorm = new Dormitory[60];
        public Dormitory[] RavenclawDorm = new Dormitory[60];
        public Dormitory[] SlytherinDorm = new Dormitory[60];
        public void DormFix()
        {
            for (int i = 0; i < 60; i++)
            {
                GryffindorDorm[i]=new Dormitory();
                HufflepuffDorm[i]=new Dormitory();
                RavenclawDorm[i]=new Dormitory();
                SlytherinDorm[i]=new Dormitory();
            }
        }
        public void PeopleSort()
        {
            for (int i = 0; i < Humans.Length; i++)
            {
                Humans[i] = new Human();
            }
            test = JsonConvert.DeserializeObject<Jsonarray[]>(Jsonstring);
            for (int i = 0; i < test.Length; ++i)
            {
                Humans[i].FirstName = test[i].name;
                Humans[i].LastName = test[i].family;
                Humans[i].BirthDate = test[i].dateOfBirth;
                Humans[i].Gender = test[i].gender;
                Humans[i].Father = test[i].father;
                Humans[i].Username = test[i].username;
                Humans[i].Password = test[i].password;
                if (test[i].type == "Pure blood")
                {
                    Humans[i].TypeOfBlood = Human.BloodType.PureBlood;
                }
                else if (test[i].type == "Half blood")
                {
                    Humans[i].TypeOfBlood = Human.BloodType.HalfBlood;
                }
                else if (test[i].type == "Muggle blood")
                {
                    Humans[i].TypeOfBlood = Human.BloodType.MuggleBlood;
                }
                if (test[i].role == "teacher")
                {
                    Humans[i].Role = Human.RoleType.Teacher;
                }
                else if (test[i].role == "student")
                {
                    Humans[i].Role = Human.RoleType.Student;
                }
            }
        }
        public void StudentSort()
        {
            for (int i = 0; i < Student.Length; i++)
            {
                Student[i] = new Students();
            }
            test = JsonConvert.DeserializeObject<Jsonarray[]>(Jsonstring);
            int j = 0;
            for (int i = 0; i < test.Length; ++i)
            {

                if (test[i].role == "student")
                {
                    Student[j].FirstName = test[i].name;
                    Student[j].LastName = test[i].family;
                    Student[j].BirthDate = test[i].dateOfBirth;
                    Student[j].Gender = test[i].gender;
                    Student[j].Father = test[i].father;
                    Student[j].Username = test[i].username;
                    Student[j].Password = test[i].password;
                    Student[j].Role = Human.RoleType.Student;
                    if (test[i].type == "Pure blood")
                    {
                        Student[j].TypeOfBlood = Human.BloodType.PureBlood;
                    }
                    else if (test[i].type == "Half blood")
                    {
                        Student[j].TypeOfBlood = Human.BloodType.HalfBlood;
                    }
                    else if (test[i].type == "Muggle blood")
                    {
                        Student[j].TypeOfBlood = Human.BloodType.MuggleBlood;
                    }
                    j++;


                }
            }
        }
        public static Globals Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Globals();
                    }
                    return instance;
                }
            }
        }
    }
}
