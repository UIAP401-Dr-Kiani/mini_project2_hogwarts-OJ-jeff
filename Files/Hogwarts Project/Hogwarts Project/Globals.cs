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
            TeacherSort(); 
            DormFix();
            Courses = new List<Courses>();
            SetCourses();
        }
        private static Globals instance = null;
        private static readonly object padlock = new object();
        public Human[] Humans = new Human[400];
        public Students[] Student = new Students[400];
        public Teachers[] Teachers = new Teachers[400]; 
        public Jsonarray[] test = new Jsonarray[300];
        public string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
        public Dormitory[] GryffindorDorm = new Dormitory[60];
        public Dormitory[] HufflepuffDorm = new Dormitory[60];
        public Dormitory[] RavenclawDorm = new Dormitory[60];
        public Dormitory[] SlytherinDorm = new Dormitory[60];
        public List<Courses> Courses { get; set; }
        public void SetCourses()
        {
            
            Courses.Add(new Botanical() { Name = "Botanical1", Capacity = 10, Term = 1, Time = "Monday,8:00" });
            Courses.Add(new Botanical() { Name = "Botanical1", Capacity = 10, Term = 1, Time = "Monday,10:00" });
            Courses.Add(new Botanical() { Name = "Botanical1", Capacity = 10, Term = 1, Time = "Tuesday,10:00" });
            Courses.Add(new Botanical() { Name = "Botanical1", Capacity = 10, Term = 1, Time = "Sunday,8:00" });
            Courses.Add(new Botanical() { Name = "Botanical2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Botanical() { Name = "Botanical2", Capacity = 10, Term = 2, Time = "Friday,12:00" });
            Courses.Add(new Botanical() { Name = "Botanical2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Botanical() { Name = "Botanical3", Capacity = 10, Term = 3, Time = "Monday,8:00" });
            Courses.Add(new Botanical() { Name = "Botanical3", Capacity = 10, Term = 3, Time = "Thursday,10:00" });
            Courses.Add(new Botanical() { Name = "Botanical4", Capacity = 10, Term = 4, Time = "Monday,8:00" });
            Courses.Add(new Sports() { Name = "Volleyball", Capacity = 12, Term = 1, Time = "Saturday,8:00" , Type= "Volleyball" });
            Courses.Add(new Sports() { Name = "Basketball", Capacity = 10, Term = 2, Time = "Friday,10:00", Type = "Basketball" });
            Courses.Add(new Sports() { Name = "Football", Capacity = 22, Term = 3, Time = "Monday,12:00" , Type = "Football" });
            Courses.Add(new Sports() { Name = "Tabletennis", Capacity = 2, Term = 4, Time = "Thursday,8:00" , Type = "Tabletennis" });
            Courses.Add(new Chemistry() { Name = "Chemistry1", Capacity = 10, Term = 1, Time = "Tuesday,8:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry1", Capacity = 10, Term = 1, Time = "Monday,10:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry1", Capacity = 10, Term = 1, Time = "Tuesday,10:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry1", Capacity = 10, Term = 1, Time = "Wednesday,8:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry2", Capacity = 10, Term = 2, Time = "Sunday,12:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry3", Capacity = 10, Term = 3, Time = "Wednesday,12:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry3", Capacity = 10, Term = 3, Time = "Thursday,10:00" });
            Courses.Add(new Chemistry() { Name = "Chemistry4", Capacity = 10, Term = 4, Time = "Saturday,8:00" });
            Courses.Add(new Occultism() { Name = "Occultism1", Capacity = 10, Term = 1, Time = "Saturday,8:00" });
            Courses.Add(new Occultism() { Name = "Occultism1", Capacity = 10, Term = 1, Time = "Monday,10:00" });
            Courses.Add(new Occultism() { Name = "Occultism1", Capacity = 10, Term = 1, Time = "Tuesday,10:00" });
            Courses.Add(new Occultism() { Name = "Occultism1", Capacity = 10, Term = 1, Time = "Monday,12:00" });
            Courses.Add(new Occultism() { Name = "Occultism2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Occultism() { Name = "Occultism2", Capacity = 10, Term = 2, Time = "Thursday,10:00" });
            Courses.Add(new Occultism() { Name = "Occultism2", Capacity = 10, Term = 2, Time = "Monday,8:00" });
            Courses.Add(new Occultism() { Name = "Occultism3", Capacity = 10, Term = 3, Time = "Wednesday,12:00" });
            Courses.Add(new Occultism() { Name = "Occultism3", Capacity = 10, Term = 3, Time = "Thursday,10:00" });
            Courses.Add(new Occultism() { Name = "Occultism4", Capacity = 10, Term = 4, Time = "Thursday,8:00" });


        }
       
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
        public void TeacherSort()
        {
            for (int i = 0; i < Teachers.Length; i++)
            {
                Teachers[i] = new Teachers();
            }
            test = JsonConvert.DeserializeObject<Jsonarray[]>(Jsonstring);
            int j = 0;
            for (int i = 0; i < test.Length; ++i)
            {

                if (test[i].role == "teacher")
                {
                    Teachers[j].FirstName = test[i].name;
                    Teachers[j].LastName = test[i].family;
                    Teachers[j].BirthDate = test[i].dateOfBirth;
                    Teachers[j].Gender = test[i].gender;
                    Teachers[j].Father = test[i].father;
                    Teachers[j].Username = test[i].username;
                    Teachers[j].Password = test[i].password;
                    Teachers[j].Role = Human.RoleType.Teacher;
                    if (test[i].type == "Pure blood")
                    {
                        Teachers[j].TypeOfBlood = Human.BloodType.PureBlood;
                    }
                    else if (test[i].type == "Half blood")
                    {
                        Teachers[j].TypeOfBlood = Human.BloodType.HalfBlood;
                    }
                    else if (test[i].type == "Muggle blood")
                    {
                        Teachers[j].TypeOfBlood = Human.BloodType.MuggleBlood;
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
