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
        private List<Button> soundPlayButtons = new List<Button>();
        private void SoundPlayButtonsInit()
        {
            List<Button> list = new List<Button>() {
                button6
            };
            soundPlayButtons.AddRange(list);
        }
    }
}
