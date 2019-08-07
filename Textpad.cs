using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haxxGame
{
    public partial class Textpad : Form
    {
        public Textpad()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        bool isTextpadopen = false;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void closeButton_Click(object sender, EventArgs e)
        {
            Props.SaveTextpad(richTextBox1.Text);
            isTextpadopen = false;
            this.Hide();
        }
        [DllImport("user32.dll")]
        static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, UIntPtr wParam, IntPtr lParam);
        [DllImport("user32")]
        public static extern int ReleaseCapture(IntPtr hwnd);
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            ReleaseCapture(ctrl.Handle);

            DragMe();
        }
        public void DragMe()
        {
            DefWindowProc(this.Handle, WM_SYSCOMMAND, (UIntPtr)MOUSE_MOVE, IntPtr.Zero);
        }

        private void Textpad_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), DisplayRectangle);
        }

        private void Textpad_Load(object sender, EventArgs e)
        {
            savetimer.Start();

            
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "todo:\nhack msa and fgi\nbecom anonymoose membar\ntake london lessonz\nbecamen smart haker";

                switch (Props.hacker)
                {
                    case Props.hackerType.Alixx:
                        richTextBox1.Text += "\nlose some weight";
                        break;

                    case Props.hackerType.Chevy:
                        richTextBox1.Text += "\nget 500 more botnets";
                        break;

                    case Props.hackerType.Hecks:
                        richTextBox1.Text += "\nlearn how a condom works";
                        break;

                    case Props.hackerType.Playingo:
                        richTextBox1.Text += "\ninject to datajase";
                        break;

                    case Props.hackerType.Toxic:
                        richTextBox1.Text += "\nsay you take sites down when they change hosts";
                        break;
                }

            }

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\SkidSimulator");
            if (key != null)
            {
                Object o = key.GetValue("textPad");
                if (o != null)
                {
                    richTextBox1.Text = o as String;
                }
            }
        }

        private void Textpad_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                isTextpadopen = true;
            else
                isTextpadopen = false;

            this.label1.Text = @"C:\anime\notepad" + Props.GetRandomExt();
        }

        private void savetimer_Tick(object sender, EventArgs e)
        {
            if (isTextpadopen)
            {
                Props.SaveTextpad(richTextBox1.Text);
            }
        }
    }
}
