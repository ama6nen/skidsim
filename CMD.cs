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
    public partial class CMD : Form
    {
        public CMD()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void CMD_Load(object sender, EventArgs e)
        {

            this.AcceptButton = button1;

         

            StoredPoint = CmdLine.Location;
            acceptcommand("");
            closeButton.FlatAppearance.BorderSize = 0;
            this.DoubleBuffered = true;
        }

     
        private string[] cmdParts;

        private string lastCmd = "";

        private void acceptcommand(string txt)
        {
       
            if (txt == "")
            {
                this.Terminal.Items.Add(@"C:\Users\wannabe> ");
                /*
                if (this.Terminal.Items.Count > 16)
                {
                    this.Terminal.Items.RemoveAt(0);
                    return;
                }
                */
             //   this.CmdLine.Location = new Point(this.CmdLine.Location.X, this.CmdLine.Location.Y + 18);
                return;
            }
            else
            {
               
                this.Terminal.Items[this.Terminal.Items.Count - 1] = @"C:\Users\wannabe> " + this.CmdLine.Text;
                this.Terminal.Items.Add(txt);
                this.Terminal.Items.Add("");
                this.Terminal.Items.Add(@"C:\Users\wannabe> ");
                this.CmdLine.Text = "";


                if (this.Terminal.Items.Count > 14)
                {
                    this.Terminal.Items.RemoveAt(0);
                    this.Terminal.Items.RemoveAt(1);
                    this.Terminal.Items.RemoveAt(2);
                    this.CmdLine.Location = new Point(this.CmdLine.Location.X, this.CmdLine.Location.Y - 69);
                }

                this.CmdLine.Location = new Point(this.CmdLine.Location.X, this.CmdLine.Location.Y + 69);
                return;
            }
        }
        private void CMD_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3), DisplayRectangle);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        [DllImport("user32.dll")]
        static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, UIntPtr wParam, IntPtr lParam);
        [DllImport("user32")]
        public static extern int ReleaseCapture(IntPtr hwnd);

        Point StoredPoint;
        Random rand = new Random();
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
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
        
        private void CmdLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.CmdLine.Text = this.lastCmd;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CmdLine.Text != "")
            {
                this.lastCmd = this.CmdLine.Text;
            }

            if(lastCmd.StartsWith("ping"))
            {
                if(lastCmd.StartsWith("ping "))
                {
                   
                        string site = lastCmd.Substring(lastCmd.LastIndexOf(' '));

                    if(site == " ")
                        acceptcommand("Empty parameter");
                    else
                    {
                        site = site.Remove(0, 1);
                        string secs = rand.Next(666, 666420).ToString();
                        acceptcommand("DDoSing " + site + " for " + secs + " seconds!");

                    }
                   
                          
                    
                }else
                {
                    acceptcommand("Usage: ping 127.0.0.1");
                }
               
            
            }
            else
            if (lastCmd.StartsWith("spoof"))
            {
                if (lastCmd.StartsWith("spoof "))
                {

                    string site = lastCmd.Substring(lastCmd.LastIndexOf(' '));

                    if (site == " ")
                        acceptcommand("Empty parameter");
                    else
                    {
                        site = site.Remove(0, 1);
                        string secs = rand.Next(666, 42069).ToString();
                        string secs2 = rand.Next(666, 42069).ToString();

                        acceptcommand("Using neighbours spoofed location for " + site + " with lat/lon: " + secs + "/" + secs2 + "!");

                    }



                }
                else
                {
                    acceptcommand("Usage: spoof <router>");
                }


            }
            else if (lastCmd.Equals("clear"))
            {
                Terminal.Items.Clear();
                CmdLine.Location = StoredPoint;
                CmdLine.Text = "";
                acceptcommand("");
            }
            else if (lastCmd.Equals("reset all"))
            {

                Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("Software\\SkidSimulator");
                acceptcommand("Every setting has been reset, restart skid sim.");
            }
            else if (lastCmd.StartsWith("name"))
            {
                if (lastCmd.StartsWith("name "))
                {

                    string name = lastCmd.Substring(lastCmd.IndexOf(' '));

                    if (name == " ")
                        acceptcommand("Empty parameter");
                    else
                    {
                        name = name.Remove(0, 1);

                        if(name.Length > 15)
                        {
                            acceptcommand("Sorry, max skid name length is 15!");
                            return;
                        }
                         
                        if (name.ToLower().Contains("ama"))
                        {
                            Props.SetSkidName(Environment.UserName);
                        }else
                        {
                            Props.SetSkidName(name);
                        }
                        acceptcommand("Your skid name has been set!");

                    }
                }
                else
                {
                    acceptcommand("Usage: name PlayingoHD");
                }


            }else if(lastCmd == "help")
            {
                acceptcommand("Help has been written into your textpad.");

                Props.staticpad.richTextBox1.Text +=("\n\nCMD Commands help:\nname <name> (Sets your name that you originally select on start menu)\nclear (Clears everything in cmd)\nping <ip> (Big Ddos attack)\nspoof <router>(Spoof your neighbours wifi location, playingo style!)\nreset all (Reset every single changed setting so far)");
                Props.SaveTextpad(Props.staticpad.richTextBox1.Text);
            }
            else if(lastCmd != "")
            this.acceptcommand("Unknown Command, type 'help' for help");
            return;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMD_VisibleChanged(object sender, EventArgs e)
        {
            if (Props.hacker == Props.hackerType.Playingo)
                label1.Text = @"C:\dllimport\system128\cmd.exe";
            else
                label1.Text = @"C:\Windows\system" + rand.Next(01, 99).ToString() + @"\cmd" + Props.GetRandomExt();
        }
    }
}
