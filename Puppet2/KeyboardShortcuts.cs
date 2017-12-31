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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.D1))
            {
                Alt_1(new int[] { 0, 1, 2, 3});
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Alt_1(int[] pictureNums)
        {
            bool customPicturesExists = true;
            foreach (int i in pictureNums)
            {
                if (File.Exists(CustomPictures.FullPath[i]) == false)
                {
                    customPicturesExists = false;
                    break;
                }
            }
            if (customPicturesExists)
            {
                SuspendLayout();
                int j = 0;
                foreach (int i in pictureNums)
                {
                    pictureBoxes[i].Image.Dispose();
                    File.Copy(CustomPictures.FullPath[i], CustomPictures.Current[j], true);
                    InitializePictureBox(pictureBoxes[i], new Bitmap(CustomPictures.Current[j]));
                    j++;
                }
                ClientSize = new Size(pictureBoxes[0].Size.Width, pictureBoxes[0].Size.Height);
                pictureBoxes[0].Visible = true;
                ResumeLayout(false);
            }
        }
    }
}
