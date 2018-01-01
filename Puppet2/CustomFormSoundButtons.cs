using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Puppet2
{
    public partial class CustomForm : Form
    {
        private List<Button> soundButtons = new List<Button>();
        private void SoundButtonsInit()
        {
            List<Button> list = new List<Button>() {
                button5
            };
            soundButtons.AddRange(list);
            int i = 0;
            foreach(Button button in soundButtons)
            {
                if (File.Exists(CustomSounds.FullPath[i]))
                {
                    button.Text = resetText;
                }
                else
                {
                    button.Text = initialText;
                }
                i++;
            }
        }
    }
}
