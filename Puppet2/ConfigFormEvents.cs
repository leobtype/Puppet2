using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puppet2
{
    public partial class ConfigForm : Form
    {
        private void SetEvents()
        {
            this.FormClosed += new FormClosedEventHandler(Form_Closed);
            numericUpDown1.ValueChanged += new EventHandler(NumericUpDown1_ValueChanged);
            trackBar1.ValueChanged += new EventHandler(TrackBar1_ValueChanged);
            trackBar2.ValueChanged += new EventHandler(TrackBar2_ValueChanged);
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            MascotForm.ResetTimer(trackBar1.Value);
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            MascotForm.ResetFrequency(trackBar2.Value);
        }

        private void NumericUpDown1_ValueChanged(Object sender, EventArgs e)
        {
            MascotForm.ResizePictureBoxes((int)numericUpDown1.Value);
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
