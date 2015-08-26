using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed))
                Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
            operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Result.Clear();
            value = 0;
        }
    }
}
