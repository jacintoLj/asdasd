﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class MachineList : Form
    {
        public MachineList()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
             
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            Payment card = new Payment();
            card.Show();
            this.Hide();


        }

        private void machineIconHome_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void Machine1Button_Click(object sender, EventArgs e)
        {
          
        }

        private void Machine7Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine6Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine5Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine4Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine3Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine2Button_Click(object sender, EventArgs e)
        {

        }

        private void Machine8Button_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
