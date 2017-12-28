using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puppet2
{
    public partial class MascotForm : Form
    {
        static Timer timer = new Timer();
        static Puppet2.Properties.Settings config = Properties.Settings.Default;
        static int blinkFrequency = config.BlinkFrequency;

        private void Motion()
        {
            Puppet2.Properties.Settings config = Properties.Settings.Default;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = config.BlinkDuration;
            timer.Start();
            //while (true) Application.DoEvents();
        }

        private static void TimerEventProcessor(object obj, EventArgs e)
        {
            if (pictureBoxes[1].Visible == true)
            {
                ToggleEyes();
                return;
            }

            Random random = new Random((int)System.DateTime.Now.Ticks);
            if (random.Next(1000) < blinkFrequency)
            {
                ToggleEyes();
            }
        }

        private static void ToggleEyes()
        {
            if (pictureBoxes[0].Visible == true )
            {
                pictureBoxes[0].Visible = false;
                pictureBoxes[1].Visible = true;
            }
            else if(pictureBoxes[1].Visible == true)
            {
                pictureBoxes[1].Visible = false;
                pictureBoxes[0].Visible = true;
            }
        }
    }
}
