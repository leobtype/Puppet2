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
        private void SetEvents()
        {
            FormClosed += new FormClosedEventHandler(Form_Closed);

            button1.DragEnter += new DragEventHandler(Button_DragEnter);
            button2.DragEnter += new DragEventHandler(Button_DragEnter);
            button3.DragEnter += new DragEventHandler(Button_DragEnter);
            button4.DragEnter += new DragEventHandler(Button_DragEnter);
            button5.DragEnter += new DragEventHandler(Button_DragEnter);

            button1.DragDrop += new DragEventHandler(Button1_DragDrop);
            button2.DragDrop += new DragEventHandler(Button2_DragDrop);
            button3.DragDrop += new DragEventHandler(Button3_DragDrop);
            button4.DragDrop += new DragEventHandler(Button4_DragDrop);
            button5.DragDrop += new DragEventHandler(Button5_DragDrop);

            button1.MouseClick += new MouseEventHandler(Button1_MouseClick);
            button2.MouseClick += new MouseEventHandler(Button2_MouseClick);
            button3.MouseClick += new MouseEventHandler(Button3_MouseClick);
            button4.MouseClick += new MouseEventHandler(Button4_MouseClick);
            button5.MouseClick += new MouseEventHandler(Button5_MouseClick);
            button6.MouseClick += new MouseEventHandler(Button6_MouseClick);
        }
    }
}
