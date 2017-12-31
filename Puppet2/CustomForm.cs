using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Puppet2
{
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
            SetEvents();
        }

        private void SetEvents()
        {
            FormClosed += new FormClosedEventHandler(Form_Closed);

            button1.DragEnter += new DragEventHandler(Button_DragEnter);
            button2.DragEnter += new DragEventHandler(Button_DragEnter);
            button3.DragEnter += new DragEventHandler(Button_DragEnter);
            button4.DragEnter += new DragEventHandler(Button_DragEnter);

            button1.DragDrop += new DragEventHandler(Button1_DragDrop);
            button2.DragDrop += new DragEventHandler(Button2_DragDrop);
            button3.DragDrop += new DragEventHandler(Button3_DragDrop);
            button4.DragDrop += new DragEventHandler(Button4_DragDrop);

            button1.MouseClick += new MouseEventHandler(Button1_MouseClick);
            button2.MouseClick += new MouseEventHandler(Button2_MouseClick);
            button3.MouseClick += new MouseEventHandler(Button3_MouseClick);
            button4.MouseClick += new MouseEventHandler(Button4_MouseClick);
        }

        private void Button_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void InitializePictureBox(PictureBox pictureBox, string file)
        {
            Bitmap bitmap = new Bitmap(file);
            float scale = Math.Max((float)pictureBox.Width / bitmap.Width, (float)pictureBox.Height / bitmap.Height);
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            //pictureBox.Location = new Point(0, 0);
            //pictureBox.Margin = new Padding(0);
            pictureBox.Size = new Size((int)(bitmap.Size.Width * scale), (int)(bitmap.Size.Height * scale));
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.TabIndex = 0;
            //pictureBox.TabStop = false;
            pictureBox.Image = bitmap;
            pictureBox.Visible = true;
        }

        private void InitializeButtonText(Button button)
        {
            button.Text = resetText;
        }

        private static string resetText = "リセット";

        private void CustomForm_Load(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            List<Button> buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            string[] file = CustomPictures.FullPath;

            int i = 0;
            foreach(PictureBox pictureBox in pictureBoxes)
            {
                if (File.Exists(file[i]))
                {
                    InitializePictureBox(pictureBox, file[i]);
                    InitializeButtonText(buttons[i]);
                }
                i++;
            }
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            if (pictureBox4.Image != null) pictureBox4.Image.Dispose();
            Dispose();
        }
    }
}
