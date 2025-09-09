using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double currentInput = 0;
        double input1 = 0;
        double input2 = 0;
        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_click(object sender)
        {
            if (textbox.Text == "ERROR")
                textbox.Clear();

            Button button = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button.Text;
            else
                textbox.Text += button.Text;

            currentInput = Convert.ToDouble(textbox.Text);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            number_click(sender);
        }


        private void button_2_Click(object sender, EventArgs e)
        {
            number_click(sender);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_5_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_8_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_9_Click(object sender, EventArgs e)
        {
            number_click(sender);

        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            number_click(sender);
        }

        private double Evaluate(string oper, double inp1, double inp2)
        {

            switch (oper)
            {
                case "+":
                    return inp1 + inp2;
                case "-":
                    return inp1 - inp2;

                case "x":
                    return inp1 * inp2;

                case "/":
                    if (inp2 == 0)
                    {
                        textbox.Text = "ERROR";
                        return double.NaN;
                    }

                    return inp1 / inp2;
                default:
                    return 0;
            }
        }

        private void HandleOperations(object sender)
        {
            string oper = ((Button)sender).Text;
            if (operation != "")
            {
                double temp = input1;
                input2 = currentInput;
                input1 = Evaluate(operation, input1, input2);

                if (!double.IsNaN(input1))
                {
                    label.Text = input1.ToString("0.######") + $" {oper}";
                    
                    currentInput = 0;
                    textbox.Text = "0";
                    operation = $"{oper}";
                }
                else
                {
                    input1 = temp;
                    input2 = 0;
                }
            }


            if (operation == "")
            {
                if (input1 == 0) input1 = currentInput;

                label.Text = input1.ToString("0.######") + $" {oper}";
                textbox.Text = "0";
                operation = $"{oper}";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            HandleOperations(sender);

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            HandleOperations(sender);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            HandleOperations(sender);
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                double temp = input1;
                input2 = currentInput;
                input1 = Evaluate(operation, input1, input2);

                if (!double.IsNaN(input1))
                {
                    textbox.Text = input1.ToString("0.######");
                    label.Text = "";

                    currentInput = 0;
                    operation = "";

                }
                else
                {
                    input1 = temp;
                    input2 = 0;
                }
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            HandleOperations(sender);

        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            textbox.Text = "0";
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            label.Text = "0";
            textbox.Text = "0";


            currentInput = 0;
            input1 = 0;
            input2 = 0;
            operation = "";
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (!textbox.Text.Contains("."))
            {
                if (textbox.Text == "")
                    textbox.Text = "0.";
                else
                    textbox.Text += ".";
            }

        }

        private void button_negate_Click(object sender, EventArgs e)
        {
            if (textbox.Text != "0" && textbox.Text != "ERROR")
            {
                double value = Convert.ToDouble(textbox.Text);
                value = value * -1;

                textbox.Text = value.ToString();
                currentInput = value;
            }
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (textbox.Text != "ERROR" && textbox.Text.Length > 0)
            {
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1, 1);
                if (textbox.Text == "")
                    textbox.Text = "0";
                currentInput = Convert.ToDouble(textbox.Text);
            }
        }

     
    }
}
