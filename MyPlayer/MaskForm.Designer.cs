namespace MyPlayer
{
    partial class MaskForm
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.maskPanel = new System.Windows.Forms.Panel();
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.setButton = new System.Windows.Forms.PictureBox();
            this.scaleButton = new System.Windows.Forms.PictureBox();
            this.siliderVolume = new MB.Controls.ColorSlider();
            this.volumeButton = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.maskPanel);
            this.panelControl.Controls.Add(this.colorSlider1);
            this.panelControl.Controls.Add(this.setButton);
            this.panelControl.Controls.Add(this.scaleButton);
            this.panelControl.Controls.Add(this.siliderVolume);
            this.panelControl.Controls.Add(this.volumeButton);
            this.panelControl.Controls.Add(this.labelTime);
            this.panelControl.Controls.Add(this.playButton);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 534);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(898, 61);
            this.panelControl.TabIndex = 1;
            // 
            // maskPanel
            // 
            this.maskPanel.BackColor = System.Drawing.Color.Transparent;
            this.maskPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.maskPanel.Location = new System.Drawing.Point(0, 0);
            this.maskPanel.Name = "maskPanel";
            this.maskPanel.Size = new System.Drawing.Size(898, 61);
            this.maskPanel.TabIndex = 18;
            this.maskPanel.MouseEnter += new System.EventHandler(this.maskPanel_MouseEnter);
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BarInnerColor = System.Drawing.Color.Gray;
            this.colorSlider1.BarOuterColor = System.Drawing.Color.Gray;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorSlider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.DodgerBlue;
            this.colorSlider1.ElapsedOuterColor = System.Drawing.Color.DodgerBlue;
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(0, 0);
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Size = new System.Drawing.Size(898, 12);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 17;
            this.colorSlider1.Text = "w";
            this.colorSlider1.ThumbOuterColor = System.Drawing.Color.DodgerBlue;
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.ThumbSize = 8;
            this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Image = global::MyPlayer.Properties.Resources.Set;
            this.setButton.Location = new System.Drawing.Point(807, 20);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(30, 30);
            this.setButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setButton.TabIndex = 10;
            this.setButton.TabStop = false;
            // 
            // scaleButton
            // 
            this.scaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleButton.Image = global::MyPlayer.Properties.Resources.FullScreen;
            this.scaleButton.Location = new System.Drawing.Point(856, 20);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(30, 30);
            this.scaleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scaleButton.TabIndex = 13;
            this.scaleButton.TabStop = false;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // siliderVolume
            // 
            this.siliderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.siliderVolume.BarInnerColor = System.Drawing.Color.DimGray;
            this.siliderVolume.BarOuterColor = System.Drawing.Color.Gray;
            this.siliderVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.siliderVolume.ElapsedInnerColor = System.Drawing.Color.DodgerBlue;
            this.siliderVolume.ElapsedOuterColor = System.Drawing.Color.DodgerBlue;
            this.siliderVolume.LargeChange = ((uint)(5u));
            this.siliderVolume.Location = new System.Drawing.Point(679, 28);
            this.siliderVolume.Name = "siliderVolume";
            this.siliderVolume.Size = new System.Drawing.Size(99, 12);
            this.siliderVolume.SmallChange = ((uint)(1u));
            this.siliderVolume.TabIndex = 15;
            this.siliderVolume.Text = "colorSlider1";
            this.siliderVolume.ThumbOuterColor = System.Drawing.Color.DodgerBlue;
            this.siliderVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.siliderVolume.ThumbSize = 8;
            this.siliderVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siliderVolume_Scroll);
            // 
            // volumeButton
            // 
            this.volumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeButton.BackColor = System.Drawing.Color.Transparent;
            this.volumeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumeButton.Image = global::MyPlayer.Properties.Resources.Volume;
            this.volumeButton.Location = new System.Drawing.Point(643, 20);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(30, 30);
            this.volumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volumeButton.TabIndex = 14;
            this.volumeButton.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(62, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(29, 12);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Time";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Image = global::MyPlayer.Properties.Resources.Play;
            this.playButton.Location = new System.Drawing.Point(3, 16);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playButton.TabIndex = 11;
            this.playButton.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 595);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MaskForm";
            this.Opacity = 0.01D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskForm";
            this.Load += new System.EventHandler(this.MaskForm_Load);
            this.DoubleClick += new System.EventHandler(this.MaskForm_DoubleClick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MaskForm_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaskForm_MouseClick);
            this.MouseEnter += new System.EventHandler(this.MaskForm_MouseEnter);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private MB.Controls.ColorSlider colorSlider1;
        private System.Windows.Forms.PictureBox setButton;
        private System.Windows.Forms.PictureBox scaleButton;
        private MB.Controls.ColorSlider siliderVolume;
        private System.Windows.Forms.PictureBox volumeButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel maskPanel;
    }
}