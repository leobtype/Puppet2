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
        private List<Button> pictureButtons = new List<Button>();
        private void PictureButtonsInit()
        {
            List<Button> list = new List<Button>() {
                button1,
                button2,
                button3,
                button4
            };
            pictureButtons.AddRange(list);
        }
    }
}
