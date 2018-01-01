using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puppet2
{
    public partial class CustomForm : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private void PictureBoxesInit()
        {
            List<PictureBox> list = new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4
            };
            pictureBoxes.AddRange(list);
        }

    }
}
