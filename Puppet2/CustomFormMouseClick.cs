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
        private static string initialText = "ここにファイルをドロップ";

        private void Button_MouseClick(PictureBox pictureBox, Button button, string file)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Visible = false;
                pictureBox.Image.Dispose();
                try
                {
                    File.Delete(file);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                button.Text = initialText;
            }
        }

        private void Button_MouseClickSound(Button button, Button playButton, TrackBar trackBar, SoundPlayer soundPlayer, string file)
        {
            if (soundPlayer.waveOut != null)
            {
                soundPlayer.waveOut.Dispose();
                soundPlayer.reader.Dispose();
                try
                {
                    File.Delete(file);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                button.Text = initialText;
                playButton.Enabled = false;
                trackBar.Value = 50;
                trackBar.Enabled = false;
            }
        }

        private void Button_MouseClickPlaySound(SoundPlayer soundPlayer, int volumeLevel)
        {
            soundPlayer.Play(volumeLevel);
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            Button_MouseClick(pictureBox1, button1, CustomPictures.FullPath[0]);
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            Button_MouseClick(pictureBox2, button2, CustomPictures.FullPath[1]);
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            Button_MouseClick(pictureBox3, button3, CustomPictures.FullPath[2]);
        }

        private void Button4_MouseClick(object sender, MouseEventArgs e)
        {
            Button_MouseClick(pictureBox4, button4, CustomPictures.FullPath[3]);
        }

        private void Button5_MouseClick(object sender, MouseEventArgs e)
        {
            Button_MouseClickSound(button5, button6, trackBar1, soundPlayers[0], CustomSounds.FullPath[0]);
        }

        private void Button6_MouseClick(object sender, MouseEventArgs e)
        {
            int volumeLevel = Properties.Settings.Default.SoundVolumeLevel1;
            Button_MouseClickPlaySound(soundPlayers[0], volumeLevel);
        }

    }
}
