﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string answer = "gorilla";
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string userAnswer = textBox1.Text;
            if (answer == userAnswer)
            {
                MessageBox.Show("!!!!You Got the right answer!!!!" );
                MessageBox.Show("!!!!And your points!!!!");

            }
            else 
                { 
                MessageBox.Show("Try again");
                }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
