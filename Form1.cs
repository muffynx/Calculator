using System;
using System.Xml.XPath;

namespace c_charp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double result;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);
            
            label1.Text = (string.Format("{0:n0}", num1) + " * ");
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number1.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number2.Text;
            
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number3.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number4.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number5.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number6.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number7.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number8.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number9.Text;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + number0.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox1.Text);
            
            label1.Text = (string.Format("{0:n0}", num1) + " + ");
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);
            
            label1.Text = (string.Format("{0:n0}", num1) + " / ");
            //label.Text = label.Text + num1 + option;
            
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);
            label1.Text =(string.Format("{0:n0}", num1) + " - ");
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //label1 = String.Empty;
            //label1.Clear();
           // bool label1 = String.IsNullOrEmpty(label1); // Returns true.
            //textBox1.Clear();
            result = 0;
            num1 = (0);
            num2 = 0;
            textBox1.Clear();
            //if (textBox1.Text == "0")
            //    textBox1.Clear()

        }

        private void button19_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;

            }
            if (option.Equals("-"))
            {
                result = num1 - num2;

            }
            if (option.Equals("*"))
            {
                result = num1 * num2;

            }
            if (option.Equals("/"))
            {
                result = num1 / num2;

            }
            textBox1.Text = (string.Format("{0:n}", result));
            label1.Text =(string.Format("{0:n0}", num1) + "" + option + "" + num2);
            //textBox1.Text=result + "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + dot.Text;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}