using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasoline
{
    public partial class TicketChoice : UserControl
    {
        public TicketChoice()
        {
            InitializeComponent();
        }

        public delegate void ChoiceEvent(String txt);

        public event ChoiceEvent onClick;

        private void button1_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(((Button)sender).Text);

        }
    }
}
