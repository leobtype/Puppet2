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
        private List<TrackBar> soundTrackBars = new List<TrackBar>();
        private void SoundTrackBarsInit()
        {
            List<TrackBar> list = new List<TrackBar>() {
                trackBar1
            };
            soundTrackBars.AddRange(list);
        }
    }
}
