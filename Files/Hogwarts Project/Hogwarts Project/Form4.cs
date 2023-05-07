﻿using System;
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
    public partial class Form4 : Form
    {
        Dumbeldore admin = Dumbeldore.Instance;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void AdminInvitation()
        {
            textBox2.Text = admin.Message;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin.TicketTime = DateTime.Now.AddMinutes(10);
            Random SeatNumber = new Random();
            Random CabinNumber = new Random();
            textBox2.Text = $"This is an invitation to Hogwarts! Your train will leave the station in {admin.TicketTime},Your cabin number is {CabinNumber.Next(10)} and your seat number is {SeatNumber.Next(100)}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.MessageReceiver = textBox1.Text;
            admin.Message = textBox2.Text;

            MessageBox.Show("SENT!");

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
