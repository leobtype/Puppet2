using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Threading;

namespace Puppet2
{
    public partial class CustomForm : Form
    {
        private bool ValidBitmap(string file)
        {
            try
            {
                Bitmap bitmap = new Bitmap(file);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidMp3(string file, SoundPlayer soundPlayer)
        {
            try
            {
                soundPlayer.Init(file);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Button_DragDrop(PictureBox pictureBox, Button button, string file, DragEventArgs e)
        {
            string[] fromFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (ValidBitmap(fromFiles[0]))
            {
                if (pictureBox.Image != null) pictureBox.Image.Dispose();
                File.Copy(fromFiles[0], file, true);
                InitializePictureBox(pictureBox, file);
                button.Text = resetText;
            }
        }

        private void Button_DragDropSound(Button button, Button playButton, TrackBar trackBar, SoundPlayer soundPlayer, string file, DragEventArgs e)
        {
            string[] fromFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (ValidMp3(fromFiles[0], new SoundPlayer()))
            {
                if (soundPlayer.waveOut != null)
                {
                    soundPlayer.waveOut.Dispose();
                    soundPlayer.reader.Dispose();
                    soundPlayer.reader.Close();
                }
                File.Copy(fromFiles[0], file, true);
                if (soundPlayer.Init(file) == true)
                {
                    playButton.Enabled = true;
                    trackBar.Enabled = true;
                    button.Text = resetText;
                }
                else
                {
                    playButton.Enabled = false;
                    trackBar.Enabled = false;
                    button.Text = initialText;
                }
            }
        }

        private void Button1_DragDrop(object sender, DragEventArgs e)
        {
            Button_DragDrop(pictureBox1, button1, CustomPictures.FullPath[0], e);
        }

        private void Button2_DragDrop(object sender, DragEventArgs e)
        {
            Button_DragDrop(pictureBox2, button2, CustomPictures.FullPath[1], e);
        }

        private void Button3_DragDrop(object sender, DragEventArgs e)
        {
            Button_DragDrop(pictureBox3, button3, CustomPictures.FullPath[2], e);
        }

        private void Button4_DragDrop(object sender, DragEventArgs e)
        {
            Button_DragDrop(pictureBox4, button4, CustomPictures.FullPath[3], e);
        }

        private void Button5_DragDrop(object sender, DragEventArgs e)
        {
            Button_DragDropSound(button5, button6, trackBar1, soundPlayers[0], CustomSounds.FullPath[0], e);
        }
    }
}
