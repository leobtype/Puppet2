using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Puppet2
{
    public partial class MascotForm : Form
    {
        static List<PictureBox> pictureBoxes;

        private void Preprocess()
        {
            this.SuspendLayout();
            string directory = @"D:\Users\moto\Source\Repos\Puppet2\Puppet2\Mascot\";
            pictureBoxes = CreatePictureBoxes(directory);
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                Controls.Add(pictureBox);
                SetMouseEvent(pictureBox);
                pictureBox.Visible = false;
            }
            ClientSize = new Size(pictureBoxes[0].Size.Width, pictureBoxes[0].Size.Height);
            pictureBoxes[0].Visible = true;
            this.ResumeLayout(false);
        }

        private List<PictureBox> CreatePictureBoxes(string directory) {
            string[] files = Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly);
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            foreach (string file in files)
            {
                PictureBox pictureBox = new PictureBox();
                InitializePictureBox(pictureBox, file);
                pictureBoxes.Add(pictureBox);
            }
            return pictureBoxes;
        }

        private void InitializePictureBox(PictureBox pictureBox, string file)
        {
            float scale = (float)Properties.Settings.Default.PictureScale / 100.0f;
            Bitmap bitmap = new Bitmap(file);
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(0);
            pictureBox.Size = new Size((int)(bitmap.Size.Width * scale), (int)(bitmap.Size.Height * scale));
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Image = bitmap;
        }
    }
}
