using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                result = int.Parse(textBox1.Text);
                if (result >= 40)
                {
                    lblHelloWorld.Text = "happy";
                }
                else if (result < 40)
                {
                    lblHelloWorld.Text = "Ahhhhhhhhh";
                }
                if (result <= 100 && result >= 80)
                {
                    lblHelloWorld.Text += "(^▽^)/";
                }
                if (result == 418)
                    lblHelloWorld.Text = "418 I’m a teapot";
            }
            catch (FormatException fe)
            {
                lblHelloWorld.Text = fe.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
