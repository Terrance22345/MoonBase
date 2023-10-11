﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //This code pop up a message box asking you a question. Then either close
            //the box or the program depending on the input.
            DialogResult dr = MessageBox.Show("Are you sure you don't want to go on the Space Adventure!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            
        {
            // Simple code that checks if the box was checked. Then allows you to press sign up
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Just shows the acccount was created then closes the program.
            MessageBox.Show("Account is Created. Welcome to the Team!");
            this.Close();
        }
    }
}
