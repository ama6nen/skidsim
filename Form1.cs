using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haxxGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
       

        Point selPoint;
        Rectangle mRect;
        bool doDraw = false;
  
        protected override void OnMouseDown(MouseEventArgs e)
        {
            selPoint = e.Location;
            foreach (Control ctrl in this.Controls)
            {
                
                if (ctrl is PictureBox)
                {
                    ctrl.BackColor = Color.Transparent;
                }else if (Props.isMenuOpen && ctrl == StartMenu)
                {
                    Props.HandleMenuShow();
                }
                
            }
        }
       
        protected override void OnMouseUp(MouseEventArgs e)
        {
            doDraw = false;
            this.Invalidate();

            if (Props.isNotifOpen)
            {
                Props.HandleNotifShow();
            }
            
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                doDraw = true;
                Point p = e.Location;
                int x = Math.Min(selPoint.X, p.X);
               int y = Math.Min(selPoint.Y, p.Y);
               int w = Math.Abs(p.X - selPoint.X);
                int h = Math.Abs(p.Y - selPoint.Y);
                mRect = new Rectangle(x, y, w, h);
                this.Invalidate();
                
            }
        }

      
        protected override void OnPaint(PaintEventArgs e)
        {
            if (doDraw)
            {
                
                SolidBrush myBrush = new SolidBrush(Color.FromArgb(85, 0, 120, 215));
                Pen piipii = new Pen(Color.FromArgb(125, 0, 120, 215));
                e.Graphics.FillRectangle(myBrush, mRect.X, mRect.Y, mRect.Width, mRect.Height);
                e.Graphics.DrawRectangle(piipii, mRect);
                
            }

        }

        private void UpdateTime()
        {
            DateTime time = DateTime.Now;
            time1.Text = time.ToShortTimeString();
            time2.Text = time.ToShortDateString();
        }
        public void StartMessage()
        {
            Microsoft.Win32.RegistryKey key2;
            key2 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
            key2.SetValue("newSkid", "");
            key2.Close();
            Props.ShowMessage("Welcome to skid simulator, the game where you can experience what it feels like to be a skid.");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\SkidSimulator");
            
                if (key == null)
                    Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");

                key = Registry.CurrentUser.OpenSubKey("Software\\SkidSimulator");

                if (key != null)
                {
                    Object o = key.GetValue("BgPath");
                    if (o != null)
                    {
                        string path = o as String;

                        try
                        {
                            if(File.Exists(path))
                            this.BackgroundImage = Image.FromFile(path);
                        }
                        catch
                        {
                            MessageBox.Show("Cannot load or find background image path.");
                        }
                    }
                    Object o2 = key.GetValue("skidName");
                    if (o2 != null)
                    {
                        string name = o2 as String;
                        Props.SetSkidName(name);
                    }
                    Object o3 = key.GetValue("newSkid");
                    if (o3 != null)
                    {
                        Props.ShowMessage("Welcome back " + skidName.Text);

                    }
                    else
                    {
                        Selector selector = new Selector();

                        Props.mainForm.Controls.Add(selector);
                    }
                    Object o4 = key.GetValue("hackerType");
                    if (o4 != null)
                    {
                        string hType = o4 as String;
                        Props.hacker = (Props.hackerType)Enum.Parse(typeof(Props.hackerType), hType);
                    }
                Object o5 = key.GetValue("Fullscreen");
                if (o5 != null)
                {
                    bool full = bool.Parse(o5 as string);
                    if (full)
                    {
                        Props.HandleFullscreen();
                    }
                }

            }



            if(Props.hacker == Props.hackerType.Hecks)
            Props.AddNotification("How does a condom work?");

            this.DoubleBuffered = true;
            Keyhook.Initialize();
            Props.staticpad = new Textpad();
            Props.staticmd = new CMD();
            itemImage1.OpenForm = Props.staticmd;
            itemImage2.OpenForm = Props.staticpad;
            itemImage4.isGT = true;
            Props.doWeInit = true;
            UpdateTime();
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {


        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void updateTime_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
           
          //  if(e.KeyChar == )
        }

        private void winbutton_Click(object sender, EventArgs e)
        {
            Props.HandleMenuShow();
        }

        private void shutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shutDown_MouseEnter(object sender, EventArgs e)
        {
            shutDown.BorderStyle = BorderStyle.FixedSingle;
        }
        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }

        public static Control FindControlAtCursor(Form form)
        {
            Point pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
                return FindControlAtPoint(form, form.PointToClient(pos));
            return null;
        }

        private void shutDown_MouseLeave(object sender, EventArgs e)
        {

            if(FindControlAtCursor(Props.mainForm) == shutDownBtn)
            {
                return;
            }
            if (FindControlAtCursor(Props.mainForm) == shutdownLabel)
            {
                return;
            }
      
            shutDown.BorderStyle = BorderStyle.None;  
        }

        private void fullScreen_MouseEnter(object sender, EventArgs e)
        {
            fullScreen.BorderStyle = BorderStyle.FixedSingle;
        }

        private void fullScreen_MouseLeave(object sender, EventArgs e)
        {
            if (FindControlAtCursor(Props.mainForm) == fullScreenIcon)
            {
                return;
            }
            if (FindControlAtCursor(Props.mainForm) == fullscreenLabel)
            {
                return;
            }
     
            fullScreen.BorderStyle = BorderStyle.None;
        }

        private void fullScreen_Click(object sender, EventArgs e)
        {
            Props.HandleFullscreen();
        }

        private void fullScreen_MouseHover(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = selectBG.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = selectBG.FileName;
                if (File.Exists(file))
                {
                    try
                    {
                        Microsoft.Win32.RegistryKey key;
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
                        key.SetValue("BgPath", file);
                        key.Close();
                        this.BackgroundImage = Image.FromFile(file);
                    }
                    catch
                    {
                        MessageBox.Show("Error setting image, maybe it's invalid");
                    }
                   
                }
                
            }
        }
      
        private void ActionCentre_Click(object sender, EventArgs e)
        {
            Props.HandleNotifShow();
        }

        private void itemImage1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifPanel_Paint(object sender, PaintEventArgs e)
        {

        }
      

      
    }
}
