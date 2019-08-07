using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haxxGame
{
    public class Props
    {
        public static Main mainForm;

        public static bool isMenuOpen = false;
        public static bool isFullScreen = false;
        public static bool isNotifOpen = false;
        public static bool doWeInit = false;
        static Random rand = new Random();
        public static hackerType hacker;
        public static Textpad staticpad;
        public static CMD staticmd;
        public enum hackerType
        {
            Playingo = 0,
            Hecks = 1,
            Alixx = 2,
            Toxic = 3,
            Chevy = 4
        };

        public enum Scam
        {
            Yes,
            No,
            Unknown
        };
        public static Skills skill;
        public struct Skills
        {
            public int Trashtalking;
            public int Insecurity;
            public int Autism;
            public int Money;
            public bool Mental;
            public int Toxicity;
            public int IQ;
            public Scam Scammer;
        };
        public static void SetupSkill(int trash, int insecurity, int autism, int money, bool mental, int toxicity, int IQ, Props.Scam scams)
        {
            skill.Trashtalking = trash;
            skill.Insecurity = insecurity;
            skill.Autism = autism;
            skill.Money = money;
            skill.Mental = mental;
            skill.Toxicity = toxicity;
            skill.IQ = IQ;
            skill.Scammer = scams;
        }
        public static void HandleFullscreen()
        {
            Props.isFullScreen = !Props.isFullScreen;

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
            key.SetValue("Fullscreen", isFullScreen);
            key.Close();

            if (Props.isFullScreen)
            {
              

              
                mainForm.notifPanel.Size = new Size(321, 500);
                mainForm.fullscreenLabel.Text = "Go Windowed";
                mainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                mainForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            }
            else
            {

                mainForm.notifPanel.Size = new Size(221, 500);
                mainForm.fullscreenLabel.Text = "Go Fullscreen";
             
                mainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                mainForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            foreach (Control ctrl in mainForm.Controls)
            {
                if (ctrl is MessageIcon)
                {
                    Point p = new Point(mainForm.Width / 2 - ctrl.Width / 2, (mainForm.Height / 2) - (ctrl.Height / 2) - 39);
                    ctrl.Location = p;
                }
            }

         
        }

        public static void SaveTextpad(string text)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
            key.SetValue("textPad", text);
            key.Close();
        }
        public static void SetHackType(hackerType type)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
            key.SetValue("hackerType", type);
            key.Close();
        }
        public static void ShowMessage(string text)
        {
            MessageIcon mIcon = new MessageIcon();
            mIcon.Message = text;
            mainForm.Controls.Add(mIcon);
        }

        static string[] Extensions = { ".exe", ".mp4", ".txt" , ".kys", ".bin" , ".mp3", ".doc", ".pdf", ".cs", ".cpp", ".res", ".bat", ".com", ".ct", ".cfg" };

        public static string GetRandomExt()
        {
            return Extensions[rand.Next(0, Extensions.Length)];
        }
        public static void AddNotification(string message)
        {
            if (mainForm.realNotif.Text == "No new notifications")
            {
                mainForm.realNotif.Text = "";
                mainForm.Refresh();
            }
            mainForm.realNotif.Text += message + "\n";
        }
       
        public static void SetSkidName(string name)
        {
            mainForm.skidName.Text = name;
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\SkidSimulator");
            key.SetValue("skidName", name);
            key.Close();
        }
        public static void HandleNotifShow()
        {
            Props.isNotifOpen = !Props.isNotifOpen;
       
            mainForm.notifPanel.BackColor = Color.FromArgb(220, 20, 20, 20);
      
            if(mainForm.realNotif.Text == "")
            {
                mainForm.realNotif.Text = "No new notifications";
            }
          //  mainForm.notifItems.BackColor = Color.FromArgb(220, 20, 20, 20);
            if (Props.isNotifOpen)
            {
                mainForm.notifPanel.Visible = true;
            }
            else
            {
                mainForm.notifPanel.Visible = false;
            }
        }
        public static void HandleMenuShow()
        {
            Props.isMenuOpen = !Props.isMenuOpen;

            mainForm.shutDown.BackColor = Color.FromArgb(200, 0, 0, 0);
            mainForm.fullScreen.BackColor = Color.FromArgb(200, 0, 0, 0);
            mainForm.StartMenu.BackColor = Color.FromArgb(200, 0, 0, 0);
            if (Props.isMenuOpen)
            {
                mainForm.StartMenu.Visible = true;
            }
            else
            {
                mainForm.StartMenu.Visible = false;
            }
        }
    }
}
