using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hogwarts_Project
{

    public partial class Form2 : Form
    {
        Dumbeldore admin =  Dumbeldore.Instance;
        Students[] Student = new Students[400];
        Jsonarray[] test = new Jsonarray[300];
        string Jsonstring = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files\\JSON_DATA.json");
        void StudentSort()
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
        int StudentFinder()
        {
            int i = 0;
            StudentSort();
            for (i = 0; i < Student.Length; i++)
            {

                if (textBox1.Text == Student[i].Username)
                {
                    label2.Text = $"WELCOME {Student[i].FirstName} {Student[i].LastName}";

                    break;
                }
            }
            return i;

        }
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(admin.TicketTime.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = StudentFinder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  if(textBox1.Text ==admin.MassageReceiver)
          //  {
                MessageBox.Show(admin.Message);
            //}
        }
    }
}
