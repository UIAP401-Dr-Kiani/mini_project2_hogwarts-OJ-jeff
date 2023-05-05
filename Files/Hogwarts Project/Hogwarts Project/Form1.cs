using Newtonsoft.Json;

namespace Hogwarts_Project
{
    public partial class Form1 : Form
    {
        Human[] Humans = new Human[400];
        Jsonarray[] test = new Jsonarray[300];
        string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
        void PeopleSort()
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int SignIn()
        {
            PeopleSort();
            for (int i = 0; i < Humans.Length; ++i)
            {
                if (textBox1.Text == Humans[i].Username && textBox2.Text == Humans[i].Password && Humans[i].Role == Human.RoleType.Student)
                {
                    return 1;
                }
                else if (textBox1.Text == Humans[i].Username && textBox2.Text == Humans[i].Password && Humans[i].Role == Human.RoleType.Teacher)
                {
                    return 2;
                }
                else if (textBox1.Text == "ADMIN" && textBox2.Text == "ADMIN")
                {
                    return 3;
                }

            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Check = SignIn();

                if (Check == 1)
                {
                    MessageBox.Show("Welcome Student!");
                    this.Hide();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else if (Check == 2)
                {

                    MessageBox.Show("Welcome Teacher!");
                    this.Hide();
                    var form3 = new Form3();
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();
                }
                else if (Check == 3)
                {
                    MessageBox.Show("Welcome Dumbeldore!");
                    this.Hide();
                    var form4 = new Form4();
                    form4.Closed += (s, args) => this.Close();
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("Please try again!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERORR!!!");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                textBox3.Text = "WELCOME TO HOGWARTS SIMULATOR";
                MessageBox.Show("ERORR!!!");
            }
            
                
        }
    }
}