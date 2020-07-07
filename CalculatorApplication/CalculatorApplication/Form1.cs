using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        string Operator = "0";
        string number1 = "";
        string number2 = "";
        string result = "";
        string percent = "";
        string potency1 = "";
        string potency2 = "";
        double number1d = 0;
        double number2d = 0;
        double resultd = 0;
        bool second = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //1
            if(Operator == "0")
            {
                number1 += "1";
                label1.Text = number1;
            }
            else
            {
                number2 += "1";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2
            if (Operator == "0")
            {
                number1 += "2";
                label1.Text = number1;
            }
            else
            {
                number2 += "2";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3
            if (Operator == "0")
            {
                number1 += "3";
                label1.Text = number1;
            }
            else
            {
                number2 += "3";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //4
            if (Operator == "0")
            {
                number1 += "4";
                label1.Text = number1;
            }
            else
            {
                number2 += "4";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //5
            if (Operator == "0")
            {
                number1 += "5";
                label1.Text = number1;
            }
            else
            {
                number2 += "5";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //6
            if (Operator == "0")
            {
                number1 += "6";
                label1.Text = number1;
            }
            else
            {
                number2 += "6";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //7
            if (Operator == "0")
            {
                number1 += "7";
                label1.Text = number1;
            }
            else
            {
                number2 += "7";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //8
            if (Operator == "0")
            {
                number1 += "8";
                label1.Text = number1;
            }
            else
            {
                number2 += "8";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //9
            if (Operator == "0")
            {
                number1 += "9";
                label1.Text = number1;
            }
            else
            {
                number2 += "9";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //0
            if (Operator == "0")
            {
                number1 += "0";
                label1.Text = number1;
            }
            else
            {
                number2 += "0";
                label1.Text = number1 + potency1 + Operator + number2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //,
            if (Operator == "0")
            {
                number1 += ",";
                label1.Text = number1;
            }
            else
            {
                number2 += ",";
                label1.Text = number1 + potency1 + Operator + number2 + potency2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //=
            number1d = Convert.ToDouble(number1);
            number2d = Convert.ToDouble(number2);

            if(potency1 == "²")
            {
                number1d = number1d * number1d;
            }

            if (potency1 == "³")
            {
                number1d = number1d * number1d * number1d;
            }

            if (potency2 == "²")
            {
                number2d = number2d * number2d;
            }

            if (potency2 == "³")
            {
                number2d = number2d * number2d * number2d;
            }

            if (Operator == "+")
            {
                if(percent == "%")
                {
                    resultd = number1d += (number1d * (number2d / 100));
                }
                else
                {
                    resultd = number1d += number2d;
                }
            }

            else if(Operator == "-")
            {
                if(percent == "%")
                {
                    resultd = number1d -= (number1d * (number2d / 100));
                }
                else
                {
                    resultd = number1d -= number2d;
                }
            }

            else if(Operator == "/")
            {
                resultd = number1d / number2d;
            }

            else if(Operator == "*")
            {
                resultd = number1d * number2d;
            }

            else if(Operator == "%")
            {
                resultd = number1d % number2d;
            }

            result = Convert.ToString(resultd);
            label1.Text = number1 + potency1 + Operator + number2 + potency2 + percent + " = " + result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //+ π
            if(second == false)
            {
                if (Operator == "0")
                {
                    Operator = "+";
                    label1.Text = number1 + potency1 + Operator;
                }
            }
            else
            {
                if(number1 == "")
                {
                    number1 = "3,14159265359";
                    label1.Text = number1;
                }
                else if(Operator != "0" && number2 == "")
                {
                    number2 = "3,14159265359";
                    label1.Text = number1 + potency1 + Operator + number2;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //- (-)
            if(second == false)
            {
                if(Operator == "0")
                {
                    Operator = "-";
                    label1.Text = number1 + potency1 + Operator;
                }
            }
            else
            {
                if(number1 == "")
                {
                    number1 += "-";
                    label1.Text = number1;
                }
                else if (number2 == "")
                {
                    number2 += "-";
                    label1.Text = number1 + potency1
                        + Operator + number2;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //* ³
            if(second == false)
            {
                if (Operator == "0")
                {
                    Operator = "*";
                    label1.Text = number1 + potency1 + Operator;
                }
            }
            else
            {
                if (Operator == "0" && number1 != "" && potency1 == "")
                {
                    potency1 += "³";
                    label1.Text = number1 + potency1;
                }
                else if (number2 != "" && potency2 == "")
                {
                    potency2 += "³";
                    label1.Text = number1 + potency1 + Operator + number2 + potency2;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // / ²
            if(second == false)
            {
                if (Operator == "0")
                {
                    Operator = "/";
                    label1.Text = number1 + potency1 + Operator;
                }
            }
            else
            {
                if (Operator == "0" && number1 != "" && potency1 == "")
                {
                    potency1 += "²";
                    label1.Text = number1 + potency1;
                }
                else if(number2 != "" && potency2 == "")
                {
                    potency2 += "²";
                    label1.Text = number1 + potency1 + Operator + number2 + potency2;
                }
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //clear
            number1 = "";
            number2 = "";
            Operator = "0";
            percent = "";
            potency1 = "";
            potency2 = "";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //%
            if(second == true)
            {
                if(Operator == "0")
                {
                    Operator = "%";
                    label1.Text = number1 + Operator;
                }
            }

            else if(number2 != "" && Operator != "/" && Operator != "*")
            {            
                percent = "%";
                label1.Text = number1 + Operator + number2 + "%";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //2nd
            if(second == false)
            {
                button5.Text = "(-)";
                button9.Text = "π";
                button14.Text = "³";
                //Prgramming %
                button16.Text = "%";
                button20.Text = "²";
                second = true;
            }
            else
            {
                button5.Text = "-";
                button9.Text = "+";
                button14.Text = "*";
                button16.Text = "%";
                button20.Text = "/";
                second = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
