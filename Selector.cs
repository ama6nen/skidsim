using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haxxGame
{
    public partial class Selector : UserControl
    {
        public Selector()
        {
            InitializeComponent();
        }
        public int Insecurity;
        public int Autism;
        public int Money;
        public bool Mental;
        public string GetStruct(int trash, int insecurity, int autism, int money, bool mental, int toxicity, int IQ, Props.Scam scams)
        {
            string build = "Traits:\nTrashtalking - " + trash.ToString();
            build += "\nInsecurity - " + insecurity.ToString();
            build += "\nAutism - " + autism.ToString();
            build += "\nMoney - " + money.ToString();
            build += "\nMental - " + mental.ToString();
            build += "\nToxicity - " + toxicity.ToString();
            build += "\nIQ - " + IQ.ToString();
            build += "\nScammer - " + scams.ToString();
            
            return build;
        }
        private void Selector_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            Point p = new Point(this.ParentForm.Width / 2 - this.Width / 2, (this.ParentForm.Height / 2) - (this.Height / 2) - 39);
            this.Location = p;

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 50001111;
            toolTip1.InitialDelay = 10;
       
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(pictureBox1, GetStruct(7, 6, 4, 1, false, 10, 45, Props.Scam.Unknown));
            toolTip1.SetToolTip(pictureBox2, GetStruct(0, 3, 10, 2, true, 10, 39, Props.Scam.Yes));
            toolTip1.SetToolTip(pictureBox3, GetStruct(2, 5, 4, 0, false, 3, 52, Props.Scam.Yes));
            toolTip1.SetToolTip(pictureBox4, GetStruct(6, 4, 5, 3, false, 8, 57, Props.Scam.Yes));
            toolTip1.SetToolTip(pictureBox5, GetStruct(2, 1, 9, 0, false, 4, 48, Props.Scam.No));
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "Toxic Hacker";
            Props.hacker = Props.hackerType.Toxic;
            Props.SetupSkill(6, 4, 5, 3, false, 8, 57, Props.Scam.Yes);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "Alixx";
            Props.hacker = Props.hackerType.Alixx;
            Props.SetupSkill(2, 5, 4, 0, false, 3, 52, Props.Scam.Yes);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "Hecks";
            Props.hacker = Props.hackerType.Hecks;
            Props.SetupSkill(0, 3, 10, 2, true, 10, 39, Props.Scam.Yes);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "Playingo";
            Props.hacker = Props.hackerType.Playingo;
            Props.SetupSkill(7, 6, 4, 1, false, 10, 45, Props.Scam.Unknown);
        }

        //kaarelyb , mrexy add !!
        private void winbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Contains("ama"))
            {
                Props.ShowMessage("No");
              //  return;
            }else
            {
                
                Props.SetSkidName(textBox1.Text);
                Props.SetHackType(Props.hacker);
                Props.mainForm.StartMessage();
                this.Hide();

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "Chevy";
            Props.hacker = Props.hackerType.Chevy;
            Props.SetupSkill(2, 1, 9, 0, false, 4, 48, Props.Scam.No);
         
        }
    }
}
