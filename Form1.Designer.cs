namespace haxxGame
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taskbar = new System.Windows.Forms.Panel();
            this.ActionCentre = new System.Windows.Forms.Button();
            this.time2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.winbutton = new System.Windows.Forms.Button();
            this.updateTime = new System.Windows.Forms.Timer(this.components);
            this.StartMenu = new System.Windows.Forms.Panel();
            this.skidName = new System.Windows.Forms.Label();
            this.fullScreen = new System.Windows.Forms.Panel();
            this.fullscreenLabel = new System.Windows.Forms.Label();
            this.fullScreenIcon = new System.Windows.Forms.Button();
            this.shutDown = new System.Windows.Forms.Panel();
            this.shutdownLabel = new System.Windows.Forms.Label();
            this.shutDownBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBG = new System.Windows.Forms.OpenFileDialog();
            this.notifPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.itemImage4 = new haxxGame.ItemImage();
            this.itemImage3 = new haxxGame.ItemImage();
            this.itemImage2 = new haxxGame.ItemImage();
            this.itemImage1 = new haxxGame.ItemImage();
            this.realNotif = new haxxGame.ListboxTransparent();
            this.taskbar.SuspendLayout();
            this.StartMenu.SuspendLayout();
            this.fullScreen.SuspendLayout();
            this.shutDown.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.notifPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.Black;
            this.taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.taskbar.Controls.Add(this.ActionCentre);
            this.taskbar.Controls.Add(this.time2);
            this.taskbar.Controls.Add(this.time1);
            this.taskbar.Controls.Add(this.winbutton);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskbar.Location = new System.Drawing.Point(0, 500);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(833, 39);
            this.taskbar.TabIndex = 4;
            // 
            // ActionCentre
            // 
            this.ActionCentre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionCentre.BackColor = System.Drawing.Color.Black;
            this.ActionCentre.BackgroundImage = global::haxxGame.Properties.Resources.actioncentre;
            this.ActionCentre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ActionCentre.FlatAppearance.BorderSize = 0;
            this.ActionCentre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ActionCentre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ActionCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionCentre.Location = new System.Drawing.Point(797, 3);
            this.ActionCentre.Name = "ActionCentre";
            this.ActionCentre.Size = new System.Drawing.Size(35, 32);
            this.ActionCentre.TabIndex = 8;
            this.ActionCentre.UseVisualStyleBackColor = false;
            this.ActionCentre.Click += new System.EventHandler(this.ActionCentre_Click);
            // 
            // time2
            // 
            this.time2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.time2.AutoSize = true;
            this.time2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time2.ForeColor = System.Drawing.Color.White;
            this.time2.Location = new System.Drawing.Point(724, 18);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(67, 17);
            this.time2.TabIndex = 7;
            this.time2.Text = "9/11/1990";
            // 
            // time1
            // 
            this.time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.time1.AutoSize = true;
            this.time1.BackColor = System.Drawing.Color.Transparent;
            this.time1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time1.ForeColor = System.Drawing.Color.White;
            this.time1.Location = new System.Drawing.Point(731, 0);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(55, 17);
            this.time1.TabIndex = 6;
            this.time1.Text = "9:99 PM";
            // 
            // winbutton
            // 
            this.winbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.winbutton.BackColor = System.Drawing.Color.Black;
            this.winbutton.BackgroundImage = global::haxxGame.Properties.Resources.winIco1;
            this.winbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winbutton.Location = new System.Drawing.Point(3, 3);
            this.winbutton.Name = "winbutton";
            this.winbutton.Size = new System.Drawing.Size(35, 35);
            this.winbutton.TabIndex = 5;
            this.winbutton.UseVisualStyleBackColor = false;
            this.winbutton.Click += new System.EventHandler(this.winbutton_Click);
            // 
            // updateTime
            // 
            this.updateTime.Enabled = true;
            this.updateTime.Interval = 5000;
            this.updateTime.Tick += new System.EventHandler(this.updateTime_Tick);
            // 
            // StartMenu
            // 
            this.StartMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartMenu.BackColor = System.Drawing.Color.Black;
            this.StartMenu.Controls.Add(this.skidName);
            this.StartMenu.Controls.Add(this.fullScreen);
            this.StartMenu.Controls.Add(this.shutDown);
            this.StartMenu.Location = new System.Drawing.Point(0, 286);
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.Size = new System.Drawing.Size(171, 214);
            this.StartMenu.TabIndex = 5;
            this.StartMenu.Visible = false;
            // 
            // skidName
            // 
            this.skidName.BackColor = System.Drawing.Color.Transparent;
            this.skidName.Dock = System.Windows.Forms.DockStyle.Top;
            this.skidName.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.skidName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skidName.Location = new System.Drawing.Point(0, 0);
            this.skidName.Name = "skidName";
            this.skidName.Size = new System.Drawing.Size(171, 30);
            this.skidName.TabIndex = 13;
            this.skidName.Text = "Unnamed Skid";
            this.skidName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullScreen
            // 
            this.fullScreen.BackColor = System.Drawing.Color.Black;
            this.fullScreen.Controls.Add(this.fullscreenLabel);
            this.fullScreen.Controls.Add(this.fullScreenIcon);
            this.fullScreen.Location = new System.Drawing.Point(3, 142);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(168, 34);
            this.fullScreen.TabIndex = 12;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click);
            this.fullScreen.MouseEnter += new System.EventHandler(this.fullScreen_MouseEnter);
            this.fullScreen.MouseLeave += new System.EventHandler(this.fullScreen_MouseLeave);
            this.fullScreen.MouseHover += new System.EventHandler(this.fullScreen_MouseHover);
            // 
            // fullscreenLabel
            // 
            this.fullscreenLabel.AutoSize = true;
            this.fullscreenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullscreenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullscreenLabel.Location = new System.Drawing.Point(34, 8);
            this.fullscreenLabel.Name = "fullscreenLabel";
            this.fullscreenLabel.Size = new System.Drawing.Size(78, 15);
            this.fullscreenLabel.TabIndex = 10;
            this.fullscreenLabel.Text = "Go Fullscreen";
            this.fullscreenLabel.Click += new System.EventHandler(this.fullScreen_Click);
            this.fullscreenLabel.MouseEnter += new System.EventHandler(this.fullScreen_MouseEnter);
            // 
            // fullScreenIcon
            // 
            this.fullScreenIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fullScreenIcon.BackColor = System.Drawing.Color.Black;
            this.fullScreenIcon.BackgroundImage = global::haxxGame.Properties.Resources.fullscreen_11_xxl;
            this.fullScreenIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fullScreenIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreenIcon.Location = new System.Drawing.Point(7, 6);
            this.fullScreenIcon.Name = "fullScreenIcon";
            this.fullScreenIcon.Size = new System.Drawing.Size(20, 20);
            this.fullScreenIcon.TabIndex = 9;
            this.fullScreenIcon.UseVisualStyleBackColor = false;
            this.fullScreenIcon.MouseEnter += new System.EventHandler(this.fullScreen_MouseEnter);
            // 
            // shutDown
            // 
            this.shutDown.BackColor = System.Drawing.Color.Black;
            this.shutDown.Controls.Add(this.shutdownLabel);
            this.shutDown.Controls.Add(this.shutDownBtn);
            this.shutDown.Location = new System.Drawing.Point(3, 177);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(168, 34);
            this.shutDown.TabIndex = 11;
            this.shutDown.Click += new System.EventHandler(this.shutDown_Click);
            this.shutDown.MouseEnter += new System.EventHandler(this.shutDown_MouseEnter);
            this.shutDown.MouseLeave += new System.EventHandler(this.shutDown_MouseLeave);
            // 
            // shutdownLabel
            // 
            this.shutdownLabel.AutoSize = true;
            this.shutdownLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shutdownLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shutdownLabel.Location = new System.Drawing.Point(34, 8);
            this.shutdownLabel.Name = "shutdownLabel";
            this.shutdownLabel.Size = new System.Drawing.Size(61, 15);
            this.shutdownLabel.TabIndex = 10;
            this.shutdownLabel.Text = "Shutdown";
            this.shutdownLabel.Click += new System.EventHandler(this.shutDown_Click);
            this.shutdownLabel.MouseEnter += new System.EventHandler(this.shutDown_MouseEnter);
            // 
            // shutDownBtn
            // 
            this.shutDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shutDownBtn.BackColor = System.Drawing.Color.Black;
            this.shutDownBtn.BackgroundImage = global::haxxGame.Properties.Resources.shutodw1;
            this.shutDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shutDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutDownBtn.Location = new System.Drawing.Point(7, 6);
            this.shutDownBtn.Name = "shutDownBtn";
            this.shutDownBtn.Size = new System.Drawing.Size(20, 20);
            this.shutDownBtn.TabIndex = 9;
            this.shutDownBtn.UseVisualStyleBackColor = false;
            this.shutDownBtn.Click += new System.EventHandler(this.shutDown_Click);
            this.shutDownBtn.MouseEnter += new System.EventHandler(this.shutDown_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem1.Text = "Set Background";
            this.toolStripMenuItem1.ToolTipText = "Set a custom background image";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // selectBG
            // 
            this.selectBG.FileName = "openFileDialog1";
            this.selectBG.Filter = "Image Files|*.png;*.gif;*.bmp;*.jpg;*.jpeg";
            // 
            // notifPanel
            // 
            this.notifPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.notifPanel.Controls.Add(this.realNotif);
            this.notifPanel.Controls.Add(this.label1);
            this.notifPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.notifPanel.Location = new System.Drawing.Point(612, 0);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(221, 500);
            this.notifPanel.TabIndex = 13;
            this.notifPanel.Visible = false;
            this.notifPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.notifPanel_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notifications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemImage4
            // 
            this.itemImage4.BackColor = System.Drawing.Color.Transparent;
            this.itemImage4.Image = global::haxxGame.Properties.Resources.gt2;
            this.itemImage4.Location = new System.Drawing.Point(104, 108);
            this.itemImage4.MemeText = "Growtopia";
            this.itemImage4.Name = "itemImage4";
            this.itemImage4.OpenForm = null;
            this.itemImage4.Size = new System.Drawing.Size(80, 80);
            this.itemImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage4.TabIndex = 17;
            this.itemImage4.TabStop = false;
            // 
            // itemImage3
            // 
            this.itemImage3.BackColor = System.Drawing.Color.Transparent;
            this.itemImage3.Image = global::haxxGame.Properties.Resources.folder;
            this.itemImage3.Location = new System.Drawing.Point(104, 12);
            this.itemImage3.MemeText = "Secret Stuff";
            this.itemImage3.Name = "itemImage3";
            this.itemImage3.OpenForm = null;
            this.itemImage3.Size = new System.Drawing.Size(80, 80);
            this.itemImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage3.TabIndex = 16;
            this.itemImage3.TabStop = false;
            // 
            // itemImage2
            // 
            this.itemImage2.BackColor = System.Drawing.Color.Transparent;
            this.itemImage2.Image = global::haxxGame.Properties.Resources.textDocum;
            this.itemImage2.Location = new System.Drawing.Point(10, 108);
            this.itemImage2.MemeText = "Textpad";
            this.itemImage2.Name = "itemImage2";
            this.itemImage2.OpenForm = null;
            this.itemImage2.Size = new System.Drawing.Size(80, 80);
            this.itemImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage2.TabIndex = 15;
            this.itemImage2.TabStop = false;
            // 
            // itemImage1
            // 
            this.itemImage1.BackColor = System.Drawing.Color.Transparent;
            this.itemImage1.Image = global::haxxGame.Properties.Resources.cmdBig;
            this.itemImage1.Location = new System.Drawing.Point(10, 12);
            this.itemImage1.MemeText = "CMD";
            this.itemImage1.Name = "itemImage1";
            this.itemImage1.OpenForm = null;
            this.itemImage1.Size = new System.Drawing.Size(80, 80);
            this.itemImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemImage1.TabIndex = 14;
            this.itemImage1.TabStop = false;
            // 
            // realNotif
            // 
            this.realNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.realNotif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realNotif.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.realNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realNotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realNotif.ForeColor = System.Drawing.Color.White;
            this.realNotif.Location = new System.Drawing.Point(0, 30);
            this.realNotif.Name = "realNotif";
            this.realNotif.ReadOnly = true;
            this.realNotif.Size = new System.Drawing.Size(221, 470);
            this.realNotif.TabIndex = 12;
            this.realNotif.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::haxxGame.Properties.Resources.skid2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 539);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.itemImage4);
            this.Controls.Add(this.itemImage3);
            this.Controls.Add(this.itemImage2);
            this.Controls.Add(this.itemImage1);
            this.Controls.Add(this.notifPanel);
            this.Controls.Add(this.StartMenu);
            this.Controls.Add(this.taskbar);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Skid Simulator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            this.StartMenu.ResumeLayout(false);
            this.fullScreen.ResumeLayout(false);
            this.fullScreen.PerformLayout();
            this.shutDown.ResumeLayout(false);
            this.shutDown.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.notifPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
  
        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.Button winbutton;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Timer updateTime;
        private System.Windows.Forms.Label time2;
        public System.Windows.Forms.Panel StartMenu;
        private System.Windows.Forms.Label shutdownLabel;
        private System.Windows.Forms.Button shutDownBtn;
        public System.Windows.Forms.Panel shutDown;
        public System.Windows.Forms.Panel fullScreen;
        private System.Windows.Forms.Button fullScreenIcon;
        internal System.Windows.Forms.Label fullscreenLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog selectBG;
        private System.Windows.Forms.Button ActionCentre;
        public System.Windows.Forms.Panel notifPanel;
        internal System.Windows.Forms.Label label1;
      
        internal System.Windows.Forms.Label skidName;
        public ListboxTransparent realNotif;
        private ItemImage itemImage1;
        private ItemImage itemImage2;
        private ItemImage itemImage3;
        private ItemImage itemImage4;
    }
}

