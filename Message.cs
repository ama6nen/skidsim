using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace haxxGame
{
    public partial class MessageIcon : UserControl
    {
        public MessageIcon()
        {
            
            InitializeComponent();
        }

        string message = String.Empty;

        [Description("Message to be shown"), Category("Data")]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        const int EM_SCROLL = 0xb5;
        const int SB_LINEDOWN = 1;
        const int SB_LINEUP = 0;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void richtextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SendMessage(richTextBox1.Handle, EM_SCROLL, SB_LINEUP, 1);
            else
                SendMessage(richTextBox1.Handle, EM_SCROLL, SB_LINEDOWN, 1);
        }
        private void Message_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, (this.ParentForm.Height / 2) - (this.Height / 2) - 39);
            this.Location = p;

            //   this.richTextBox1.MouseWheel += new MouseEventHandler(richtextBox1_MouseWheel);
            Props.AddNotification("LOG: "  + message);
            richTextBox1.Text = message;
      
            richTextBox1.ReadOnly = true;
            this.Visible = true;
            this.BringToFront();
        }

        private void winbutton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            this.Dispose();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
  
        }
    }
}
