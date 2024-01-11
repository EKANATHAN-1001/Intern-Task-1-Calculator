using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        float n1, n2;
        char op;

        public Form1()
        {
            InitializeComponent();

            message1.Num = "9658741230";
            message2.Num = "8745120369";
            message1.Msg = "How are you";
            message2.Msg = "Amount credicted";
            Message.MessageReadEvent += MsgReadEvent;
        }
        public void MsgReadEvent(object sender,string str)
        {
            MessageBox.Show(str);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n2 = float.Parse(textBox1.Text);
            if (op == '+')
                textBox1.Text = (n1 + n2).ToString();
            else if (op == '-')
                textBox1.Text = (n1 - n2).ToString();
            else if (op == '*')
                textBox1.Text = (n1 * n2).ToString();
            else if (op == '/')
            {
                if (n2 != 0)
                    textBox1.Text = (n1 / n2).ToString();
                else
                    textBox1.Text = "Can't divide ";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op = '+';
            Console.WriteLine(textBox1.Text);
            n1 = float.Parse(textBox1.Text);
            textBox1.Text = "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = '-';
            Console.WriteLine(textBox1.Text);
            n1 = float.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = '*';
            Console.WriteLine(textBox1.Text);
            n1 = float.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = '/';
            Console.WriteLine(textBox1.Text);
            n1 = float.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void message1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==null || textBox1.Text=="0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
    }
}
