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
        private void Button_DragDrop(PictureBox pictureBox, Button button, string file, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fromFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (pictureBox.Image != null) pictureBox.Image.Dispose();
                File.Copy(fromFiles[0], file, true);
                InitializePictureBox(pictureBox, file);
                button.Text = resetText;
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
    }
}
