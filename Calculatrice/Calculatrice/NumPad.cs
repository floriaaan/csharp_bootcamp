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
    public partial class NumPad : UserControl
    {
        public NumPad()
        {
            InitializeComponent();
        }

        public delegate void NumPadEvent(String txt);

        public event NumPadEvent onClick;
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Value = 7
            if(onClick != null)
            {
                onClick(((Button) sender).Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Value = 1
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Value = 2
            if(onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Value = 3
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Value = 4
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Value = 5
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Value = 6
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Value = 8
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Value = 9
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Value = +
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Value = -
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Value = *
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Value = /
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Value = =
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Value = 0
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Value = .
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (onClick != null)
            {
                onClick(((Button)sender).Text);
            }
        }
    }
}
