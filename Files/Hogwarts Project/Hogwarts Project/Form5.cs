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
    public partial class Form5 : Form
    {
        Dumbeldore admin = Dumbeldore.Instance;
        Globals globals = Globals.Instance;
        int Check = 1;
        int Check1 = 0;
        int Check2 = 0;
        string TimeCheck = "";
        string InfoCheck = "";
        //Form7 form7 = new Form7();

        int IndexFinder()
        {
            //globals.StudentSort();
            int i = 0;
            for (i = 0; i < globals.Student.Length; i++)
            {
                if (globals.Student[i].Username == label1.Text)
                {
                    break;
                }
            }
            return i;
        }
        int DormIndex = 0;

        int GDormFloor = 1;
        int GDormRoomNumber = 1;
        int GDormBedNumber = 1;
        int HDormFloor = 1;
        int HDormRoomNumber = 1;
        int HDormBedNumber = 1;
        int RDormFloor = 1;
        int RDormRoomNumber = 1;
        int RDormBedNumber = 1;
        int SDormFloor = 1;
        int SDormRoomNumber = 1;
        int SDormBedNumber = 1;

        public void Label1Text(string Username)
        {
            label1.Text = Username;
        }
        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int Index = IndexFinder();
            globals.Student[Index].CurrentCourses = new List<Courses>();
            label3.Text = $"Welcome {globals.Student[Index].FirstName} {globals.Student[Index].LastName}";
            label6.Text = $"Term: {globals.Student[Index].Term.ToString()}";
            comboBox1.DataSource = globals.Courses;
            comboBox1.Hide();
            button1.Hide();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Check1 == 1)
                {
                    Exception exception = new Exception();
                    throw exception;
                }
                else
                {
                    int Index = IndexFinder();
                    Random random = new Random();
                    int RandomNumber = random.Next(3);
                    if (RandomNumber == 0)
                    {
                        globals.Student[Index].Group = GroupType.Gryffindor;
                    }
                    else if (RandomNumber == 1)
                    {
                        globals.Student[Index].Group = GroupType.Hufflepuff;
                    }
                    else if (RandomNumber == 2)
                    {
                        globals.Student[Index].Group = GroupType.Ravenclaw;
                    }
                    else if (RandomNumber == 3)
                    {
                        globals.Student[Index].Group = GroupType.Slytherin;
                    }
                    label4.Text = $"Group:{globals.Student[Index].Group}";
                    Check1 = 1;
                }

            }
            catch (Exception)
            {


            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == false || Check2 == 1)
                {
                    Exception exception = new Exception();
                    throw exception;
                }
                else
                {
                    int Index = IndexFinder();
                    if (globals.Student[Index].Group == GroupType.Gryffindor)
                    {

                        globals.GryffindorDorm[DormIndex].Floor = GDormFloor;
                        globals.GryffindorDorm[DormIndex].RoomNumber = GDormRoomNumber;
                        globals.GryffindorDorm[DormIndex].BedNumber = GDormBedNumber;
                        globals.GryffindorDorm[DormIndex].Username = globals.Student[Index].Username;
                        globals.Student[Index].DormitoryNumber = 100 * GDormFloor + 10 * GDormRoomNumber + GDormBedNumber;
                        label5.Text = $"Dorm Code:{globals.Student[Index].DormitoryNumber}";
                        if (GDormBedNumber < Dormitory.BedsPerRoom)
                        {
                            ++GDormBedNumber;
                        }
                        else
                        {
                            GDormBedNumber = 1;
                            if (GDormRoomNumber < Dormitory.RoomsPerFloor)
                            {
                                ++GDormRoomNumber;
                            }
                            else
                            {
                                GDormRoomNumber = 1;
                                ++GDormFloor;
                            }
                        }
                    }
                    else if (globals.Student[Index].Group == GroupType.Hufflepuff)
                    {
                        globals.HufflepuffDorm[DormIndex].Floor = HDormFloor;
                        globals.HufflepuffDorm[DormIndex].RoomNumber = HDormRoomNumber;
                        globals.HufflepuffDorm[DormIndex].BedNumber = HDormBedNumber;
                        globals.HufflepuffDorm[DormIndex].Username = globals.Student[Index].Username;
                        globals.Student[Index].DormitoryNumber = 100 * HDormFloor + 10 * HDormRoomNumber + HDormBedNumber;
                        label5.Text = $"Dorm Code:{globals.Student[Index].DormitoryNumber}";
                        if (HDormBedNumber < Dormitory.BedsPerRoom)
                        {
                            ++HDormBedNumber;
                        }
                        else
                        {
                            HDormBedNumber = 1;
                            if (HDormRoomNumber < Dormitory.RoomsPerFloor)
                            {
                                ++HDormRoomNumber;
                            }
                            else
                            {
                                HDormRoomNumber = 1;
                                ++HDormFloor;
                            }
                        }
                    }
                    else if (globals.Student[Index].Group == GroupType.Ravenclaw)
                    {
                        globals.RavenclawDorm[DormIndex].Floor = RDormFloor;
                        globals.RavenclawDorm[DormIndex].RoomNumber = RDormRoomNumber;
                        globals.RavenclawDorm[DormIndex].BedNumber = RDormBedNumber;
                        globals.RavenclawDorm[DormIndex].Username = globals.Student[Index].Username;
                        globals.Student[Index].DormitoryNumber = 100 * RDormFloor + 10 * RDormRoomNumber + RDormBedNumber;
                        label5.Text = $"Dorm Code:{globals.Student[Index].DormitoryNumber}";
                        if (RDormBedNumber < Dormitory.BedsPerRoom)
                        {
                            ++RDormBedNumber;
                        }
                        else
                        {
                            RDormBedNumber = 1;
                            if (RDormRoomNumber < Dormitory.RoomsPerFloor)
                            {
                                ++RDormRoomNumber;
                            }
                            else
                            {
                                RDormRoomNumber = 1;
                                ++RDormFloor;
                            }
                        }

                    }
                    else if (globals.Student[Index].Group == GroupType.Slytherin)
                    {
                        globals.SlytherinDorm[DormIndex].Floor = SDormFloor;
                        globals.SlytherinDorm[DormIndex].RoomNumber = SDormRoomNumber;
                        globals.SlytherinDorm[DormIndex].BedNumber = SDormBedNumber;
                        globals.SlytherinDorm[DormIndex].Username = globals.Student[Index].Username;
                        globals.Student[Index].DormitoryNumber = 100 * SDormFloor + 10 * SDormRoomNumber + SDormBedNumber;
                        label5.Text = $"Dorm Code:{globals.Student[Index].DormitoryNumber}";
                        if (SDormBedNumber < Dormitory.BedsPerRoom)
                        {
                            ++SDormBedNumber;
                        }
                        else
                        {
                            SDormBedNumber = 1;
                            if (SDormRoomNumber < Dormitory.RoomsPerFloor)
                            {
                                ++SDormRoomNumber;
                            }
                            else
                            {
                                SDormRoomNumber = 1;
                                ++SDormFloor;
                            }
                        }

                    }
                    Check2 = 1;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERORR!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            button1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Check == 5)
                {
                    button1.Hide();
                    Exception exception = new Exception();
                    throw exception;
                }
                int Index = IndexFinder();
                if (globals.Courses[comboBox1.SelectedIndex].Teacher != null && globals.Courses[comboBox1.SelectedIndex].Term <= globals.Student[Index].Term && globals.Courses[comboBox1.SelectedIndex].Time != TimeCheck && globals.Courses[comboBox1.SelectedIndex].Info != InfoCheck)
                {
                    listBox1.Items.Add(globals.Courses[comboBox1.SelectedIndex].ToString());
                    globals.Student[Index].CurrentCourses.Add(globals.Courses[comboBox1.SelectedIndex]);
                    TimeCheck = globals.Courses[comboBox1.SelectedIndex].Time;
                    InfoCheck = globals.Courses[comboBox1.SelectedIndex].Info;
                    comboBox1.Text = null;
                    ++Check;


                }
                else
                {
                    Exception exception = new Exception();
                    throw exception;
                }





            }
            catch (Exception)
            {
                MessageBox.Show("Erorr!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            if (Courses.HasBHomework)
            {
                int Index = IndexFinder();
                form6.LabelText(Index);
                form6.ShowDialog();

            }
            else
            {
                MessageBox.Show("There is no homework!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Courses.HasCHomework)
            {
                //form6.ShowDialog();

            }
            else
            {
                MessageBox.Show("There is no homework!");
            }
        }
    }
}
