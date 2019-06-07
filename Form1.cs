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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        bool equalsClicked = false;
        string num1 = "";

        string num2 = "";

        double number1 = 0.0;
        double number2 = 0.0;

        string operation = "";

        private void One_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }

            TextField.AppendText("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("9");
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("0");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextField.Clear();
            num1 = "";

            num2 = "";

            number1 = 0.0;
            number2 = 0.0;

            operation = "";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            TextField.AppendText(".");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operation = "divide";
            if (equalsClicked) equalsClicked = false;
            if (TextField.TextLength == 0)
            {
                num1 = "0";
            }
            else if (num1 == "")
            {
                num1 = TextField.Text;
                TextField.Clear();
            }
            else
            {
                num2 = TextField.Text;
                TextField.Clear();
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
                num1 = Convert.ToString(number1 / number2);
                TextField.Text = num1;
                num1 = "";
                operation = "";
            }
            
        }

        private void Times_Click(object sender, EventArgs e)
        {
            operation = "multiply";
            if (equalsClicked) equalsClicked = false;
            if (TextField.TextLength == 0 )
            {
                num1 = "0";
            }
            else if (num1 == "")
            {
                num1 = TextField.Text;
                TextField.Clear();
            }
            else
            {
                num2 = TextField.Text;
                TextField.Clear();
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
                num1 = Convert.ToString(number1 * number2);
                TextField.Text = num1;
                num1 = "";
                operation = "";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operation = "minus";
            if (equalsClicked) equalsClicked = false;
            if (TextField.TextLength == 0)
            {
                num1 = "0";
            }
            else if (num1 == "")
            {
                num1 = TextField.Text;
                TextField.Clear();
            }
            else
            {
                num2 = TextField.Text;
                TextField.Clear();
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
                num1 = Convert.ToString(number1 / number2);
                TextField.Text = num1;
                num1 = "";
                operation = "";
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            operation = "sum";
            if (equalsClicked) equalsClicked = false;
            if (TextField.TextLength == 0)
            {
                num1 = "0";
            }
            else if (num1 == "")
            {
                num1 = TextField.Text;
                TextField.Clear();
            }
            else
            {
                num2 = TextField.Text;
                TextField.Clear();
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
                num1 = Convert.ToString(number1 + number2);
                TextField.Text = num1;
                num1 = "";
                operation = "";
            }
        }



        private void Equal_Click(object sender, EventArgs e)
        {
            equalsClicked = true;
            switch (operation)
            {
                case "multiply":
                    num2 = TextField.Text;
                    double prod = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                    TextField.Text = Convert.ToString(prod);
                    break;
                case "divide":
                    num2 = TextField.Text;
                    double quot = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    TextField.Text = Convert.ToString(quot);
                    break;
                case "sum":
                    num2 = TextField.Text;
                    double sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                    TextField.Text = Convert.ToString(sum);
                    break;
                case "minus":
                    num2 = TextField.Text;
                    double diff = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                    TextField.Text = Convert.ToString(diff);
                    break;
                case "modulus":
                    num2 = TextField.Text;
                    int mod = Convert.ToInt32(num1) % Convert.ToInt32(num2);
                    TextField.Text = Convert.ToString(mod);
                    break;
                default:

                    break;
            }
            num1 = "";
            
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            if (equalsClicked)
            {
                TextField.Clear();
                num1 = "";

                num2 = "";

                number1 = 0.0;
                number2 = 0.0;

                operation = "";
            }
            TextField.AppendText("-");
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            operation = "modulus";
            if (equalsClicked) equalsClicked = false;
            if (TextField.TextLength == 0)
            {
                num1 = "0";
            }
            else if (num1 == "")
            {
                num1 = TextField.Text;
                TextField.Clear();
            }
            else
            {
                num2 = TextField.Text;
                TextField.Clear();
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
                num1 = Convert.ToString(number1 % number2);
                TextField.Text = num1;
                num1 = "";
                operation = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
