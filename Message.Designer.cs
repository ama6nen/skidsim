namespace haxxGame
{
    partial class MessageIcon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new haxxGame.ListboxTransparent();
            this.SuspendLayout();
            // 
            // winbutton
            // 
            this.winbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(215)))));
            this.winbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winbutton.ForeColor = System.Drawing.Color.White;
            this.winbutton.Location = new System.Drawing.Point(9, 74);
            this.winbutton.Name = "winbutton";
            this.winbutton.Size = new System.Drawing.Size(261, 30);
            this.winbutton.TabIndex = 6;
            this.winbutton.Text = "OK";
            this.winbutton.UseVisualStyleBackColor = false;
            this.winbutton.Click += new System.EventHandler(this.winbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(9, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(261, 65);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // MessageIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.winbutton);
            this.Name = "MessageIcon";
            this.Size = new System.Drawing.Size(279, 113);
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button winbutton;
        private ListboxTransparent richTextBox1;
    }
}
