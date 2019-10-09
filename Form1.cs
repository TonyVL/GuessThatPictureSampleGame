using System;
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
    public partial class Form1 : Form
    {
        
        
        
        

        public  Form1()
        {
            InitializeComponent();
            
        }
        int count = 100;
        private void Label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            label1.Visible = false; 
            count -= 4;
           
        }

        private void Label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
            count -= 4;
        }

        private void Label3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            count -= 4;
        }

        private void Label4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            count -= 4;
        }

        private void Label5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label5.Visible = false;
            count -= 4;
        }

        private void Label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
            count -= 4;
        }

        private void Label7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label7.Visible = false;
            count -= 4;
        }

        private void Label8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label8.Visible = false;
            count -= 4;
        }

        private void Label9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label9.Visible = false;
            count -= 4;
        }

        private void Label10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label10.Visible = false;
            count -= 4;

        }

        private void Label11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label11.Visible = false;
            count -= 4;
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            count -= 4;

        }

        private void Label13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label13.Visible = false;
            count -= 4;

        }

        private void Label14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label14.Visible = false;
            count -= 4;
        }

        private void Label15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label15.Visible = false;
            count -= 4;

        }

        private void Label16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label16.Visible = false;
            count -= 4;

        }

        private void Label17_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label17.Visible = false;
            count -= 4;

        }

        private void Label18_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label18.Visible = false;
            count -= 4;

        }

        private void Label19_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label19.Visible = false;
            count -= 4;

        }

        private void Label20_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label20.Visible = false;
            count -= 4;

        }

        private void Label21_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label21.Visible = false;
            count -= 4;

        }

        private void Label22_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label22.Visible = false;
            count -= 4;

        }

        private void Label23_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label23.Visible = false;
            count -= 4;

        }

        private void Label24_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label24.Visible = false;
            count -= 4;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            MessageBox.Show( Convert.ToString(count));
           
        }
        

    }
}
