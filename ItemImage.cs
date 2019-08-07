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
using System.Diagnostics;
using System.IO;

namespace haxxGame
{
    public partial class ItemImage : PictureBox
    {
        private Point MouseDownLocation;
        private Form pForm;
        private string label = "NULL";
	    private bool inited = false;
        private Label leet;
        public bool isGT = false;
        public ItemImage()
        {
            
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(80, 80);
            InitializeComponent();
        }
        private async void ok()
        {
            leet = new Label();
            leet.Text = label;
            leet.ForeColor = Color.White;
            leet.Font = new Font("Segoe UI", 9f);
            leet.Location = new Point(this.Left  + 5 , this.Bottom - 1);
            leet.BackColor = Color.Transparent;
            leet.AutoSize = true;
            leet.TextAlign = ContentAlignment.MiddleCenter;        
           // leet.Size = new Size(new Point(label.Length * 12, 15));
            leet.Parent = this;
            await Task.Delay(150);
            Props.mainForm.Controls.Add(leet);
        }

    

        [Description("Form which will be opened on double click"), Category("Data")]
        public Form OpenForm
        {
            get { return pForm; }
            set { pForm = value; }
        }

        [Description("Form which will be opened on double click"), Category("Data")]
        public string MemeText
        {
            get { return label; }
            set { label = value; }
        }
        private void ItemImage_MouseDown(object sender, MouseEventArgs e)
        {
            this.SendToBack();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 0, 120, 215);
                MouseDownLocation = e.Location;
            }
        }

  

        private void ItemImage_MouseMove(object sender, MouseEventArgs e)
        {
          
            this.SendToBack();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                leet.Location = new Point(this.Left + 5, this.Bottom - 1 );
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
            else
            {
            }
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        async void Opengt()
        {
            string gt = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Growtopia\Growtopia.exe";
            if (!File.Exists(gt)){
                Props.ShowMessage("Growtopia path does not exist, currently only supports the default location on local appdata.");
                return;
            }
            Process p = Process.Start(gt);


            for (int i = 0; i < 20; i++)
            {
                SetParent(p.MainWindowHandle, Props.mainForm.Handle);
                await Task.Delay(100);
            }
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            if (isGT) {
                Opengt();
                return; }
            pForm.TopLevel = false;
            Props.mainForm.Controls.Add(pForm);
            pForm.Show();
            pForm.BringToFront();
        }
        private void ItemImage_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private Point LocationOnClient(Control c)
        {
            Point retval = new Point(0, 0);
            for (; c.Parent != null; c = c.Parent)
            { retval.Offset(c.Location); }
            return retval;
        }


       
        private void ItemImage_Paint(object sender, PaintEventArgs e)
        {
            if (Props.doWeInit)
            {
                if (!inited) { inited = true; ok(); }
            }
        }
    }
}
