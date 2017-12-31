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


    }
}
