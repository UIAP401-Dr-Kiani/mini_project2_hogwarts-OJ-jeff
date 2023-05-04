using Newtonsoft.Json;

namespace Hogwarts_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Human[] Humans = new Human[400];
            for (int i = 0; i < 400; ++i)
            {
                Humans[i] = new Human();
            }
            string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
            Jsonarray[] test = new Jsonarray[300];
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}