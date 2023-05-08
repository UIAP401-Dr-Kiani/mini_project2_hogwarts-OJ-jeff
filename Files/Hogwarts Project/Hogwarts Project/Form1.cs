using Newtonsoft.Json;

namespace Hogwarts_Project
{
    public partial class Form1 : Form
    {
       Globals globals=Globals.Instance;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globals.StudentSort();
            globals.Student[0].HasLuggage = true;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int SignIn()
        {
            globals.PeopleSort();
            for (int i = 0; i < globals.Humans.Length; ++i)
            {
                if (textBox1.Text == globals.Humans[i].Username && textBox2.Text == globals.Humans[i].Password && globals.Humans[i].Role == Human.RoleType.Student)
                {
                    return 1;
                }
                else if (textBox1.Text == globals.Humans[i].Username && textBox2.Text == globals.Humans[i].Password && globals.Humans[i].Role == Human.RoleType.Teacher)
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
                    form2.Label1Text(textBox1.Text);
                    form2.ShowDialog();
                    this.Show();
                }
                else if (Check == 2)
                {

                    MessageBox.Show("Welcome Teacher!");
                    this.Hide();
                    var form3 = new Form3();
                    form3.ShowDialog();
                    this.Show();
                }
                else if (Check == 3)
                {
                    MessageBox.Show("Welcome Dumbeldore!");
                    this.Hide();
                    var form4 = new Form4();
                    form4.ShowDialog();
                    this.Show();
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
                MessageBox.Show("ERORR!!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                
        }
    }
}