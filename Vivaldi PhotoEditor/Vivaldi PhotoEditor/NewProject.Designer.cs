namespace Vivaldi_PhotoEditor
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.zeroitLollipopTextBox1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.zeroitLollipopButton1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.SuspendLayout();
            // 
            // zeroitLollipopTextBox1
            // 
            this.zeroitLollipopTextBox1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.zeroitLollipopTextBox1.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.zeroitLollipopTextBox1.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.zeroitLollipopTextBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitLollipopTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitLollipopTextBox1.IsEnabled = true;
            this.zeroitLollipopTextBox1.Location = new System.Drawing.Point(12, 26);
            this.zeroitLollipopTextBox1.MaxLength = 32767;
            this.zeroitLollipopTextBox1.Multiline = false;
            this.zeroitLollipopTextBox1.Name = "zeroitLollipopTextBox1";
            this.zeroitLollipopTextBox1.PasswordChar = '\0';
            this.zeroitLollipopTextBox1.ReadOnly = false;
            this.zeroitLollipopTextBox1.Size = new System.Drawing.Size(352, 24);
            this.zeroitLollipopTextBox1.TabIndex = 0;
            this.zeroitLollipopTextBox1.Text = "ProjectName";
            this.zeroitLollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.zeroitLollipopTextBox1.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.zeroitLollipopTextBox1.UseSystemPasswordChar = false;
            this.zeroitLollipopTextBox1.WordWrap = true;
            // 
            // zeroitLollipopButton1
            // 
            this.zeroitLollipopButton1.AllowTransparency = true;
            this.zeroitLollipopButton1.AnimationInterval = 1;
            this.zeroitLollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitLollipopButton1.BGColor = "#508ef5";
            this.zeroitLollipopButton1.Corners = 1F;
            this.zeroitLollipopButton1.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.zeroitLollipopButton1.DoubleRipple = false;
            this.zeroitLollipopButton1.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.zeroitLollipopButton1.FontColor = "#ffffff";
            this.zeroitLollipopButton1.ForeColor = System.Drawing.Color.White;
            this.zeroitLollipopButton1.Location = new System.Drawing.Point(447, 117);
            this.zeroitLollipopButton1.Name = "zeroitLollipopButton1";
            this.zeroitLollipopButton1.RippleEffectColor = System.Drawing.Color.Black;
            this.zeroitLollipopButton1.RippleOpacity = 25;
            this.zeroitLollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.zeroitLollipopButton1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitLollipopButton1.TabIndex = 1;
            this.zeroitLollipopButton1.Text = "Create project";
            this.zeroitLollipopButton1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.zeroitLollipopButton1.Click += new System.EventHandler(this.zeroitLollipopButton1_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 170);
            this.Controls.Add(this.zeroitLollipopButton1);
            this.Controls.Add(this.zeroitLollipopTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivaldi - Create new project";
            this.ResumeLayout(false);

        }

        #endregion

        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox zeroitLollipopTextBox1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton zeroitLollipopButton1;
    }
}