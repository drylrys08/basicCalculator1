using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double cal,num;

        

        private void Screen2Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Screen1Label.Text = Screen1Label.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            Screen1Label.Text = Screen1Label.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
            Screen1Label.Text = Screen1Label.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Screen1Label.Text = Screen1Label.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
            Screen1Label.Text = Screen1Label.Text + "0";
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            Screen1Label.Text = Screen1Label.Text + ".";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
            cal = 1;
          
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
            cal = 2;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
            cal = 3;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
            cal = 4;
        }
        private void moduloButton_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
            cal = 5;
        }

        private void buttonSquared_Click(object sender, EventArgs e)
        {
            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";
           
            num = Math.Pow(double.Parse(Screen2Label.Text), 2);
            Screen1Label.Text = num.ToString();
            
        }
        private void buttonHalf_Click(object sender, EventArgs e)
        {
            

            Screen2Label.Text = Screen1Label.Text;
            Screen1Label.Text = "";

            num = 1 / double.Parse(Screen2Label.Text);
            Screen1Label.Text = num.ToString();
           
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (cal)
            {
                case 1:
                    num = double.Parse(Screen2Label.Text) + double.Parse(Screen1Label.Text);
                    Screen1Label.Text = num.ToString();
                    break;
                case 2:
                    num = double.Parse(Screen2Label.Text) - double.Parse(Screen1Label.Text);
                    Screen1Label.Text = num.ToString();
                    break;
                case 3:
                    num = double.Parse(Screen2Label.Text) * double.Parse(Screen1Label.Text);
                    Screen1Label.Text = num.ToString();
                    break;
                case 4:
                    num = double.Parse(Screen2Label.Text) / double.Parse(Screen1Label.Text);
                    Screen1Label.Text = num.ToString();
                    break;
                case 5:
                    num = double.Parse(Screen2Label.Text) % double.Parse(Screen1Label.Text);
                    Screen1Label.Text = num.ToString();
                    break;
                

            }
           
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Screen1Label.Text = null;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Screen1Label.Text = null;
            Screen2Label.Text = null;
        }
    }
}
