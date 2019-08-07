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
    public partial class ListboxTransparent : RichTextBox
    {
        public ListboxTransparent()
        {
           // this.SetStyle(ControlStyles.UserPaint, true);
          //  this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                //This makes the control's background transparent
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }
        private void ListboxTransparent_Load(object sender, EventArgs e)
        {

        }
    }
}
