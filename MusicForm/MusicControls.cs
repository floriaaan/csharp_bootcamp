using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicForm
{
    public partial class MusicControls : UserControl
    {
        public MusicControls()
        {
            InitializeComponent();
        }

        public delegate void MusicControlEvent(String txt);

        public event MusicControlEvent onClick;

        private void musicValidateBtn_Click(object sender, EventArgs e)
        {
            onClick?.Invoke(musicID.Text);
        }
    }
}
