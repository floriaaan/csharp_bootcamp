using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public float a = 0;
        public float b = 0;
        public string operand = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void numPad1_Load(object sender, EventArgs e)
        {
            numPad1.onClick += NumPad1_onClick;
        }

        private void NumPad1_onClick(string txt)
        {
            if (txt == "Clear")
            {
                textBox1.Text = "";
                a = 0;
                b = 0;
                operand = "";
            }
            if (txt == "=")
            {
                float result;
                if(operand == "+")
                {
                    result = a + b;
                } else if (operand == "-")
                {
                    result = a - b;
                }
                else if (operand == "*")
                {
                    result = a * b;
                }
                else if (operand == "/")
                {
                    if(b != 0)
                    {
                        result = a / b;
                    } else
                    {
                        result = 0;
                    }
                    
                } else
                {
                    result = 0;
                }


                textBox2.Text = "= " + result;
                
            } else if (operand != "" && a!= 0)
            {
                b += float.Parse(txt);
            }
            else if (operand == "" && txt != "+" && txt != "-" && txt != "*" && txt != "/" && txt != "Clear")
            {
                String temp = a.ToString() + txt;
                a = float.Parse(temp);
                
            }
            else if (txt == "+")
            {
                operand = "+";
            }
            else if (txt == "-")
            {
                operand = "-";

            }
            else if (txt == "*")
            {
                operand = "*";

            }
            else if (txt == "/")
            {
                operand = "/";

            }
             
            if(txt != "=" && txt != "Clear")
            {

                textBox1.Text += txt;
            }
            
            

        }
    }
}
