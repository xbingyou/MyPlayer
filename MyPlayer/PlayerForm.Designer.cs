namespace MyPlayer
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.pictureBuffer = new System.Windows.Forms.Label();
            this.backGround = new System.Windows.Forms.PictureBox();
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelBuffer = new System.Windows.Forms.Label();
            this.PlayProgress = new System.Windows.Forms.PictureBox();
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.setButton = new System.Windows.Forms.PictureBox();
            this.scaleButton = new System.Windows.Forms.PictureBox();
            this.siliderVolume = new MB.Controls.ColorSlider();
            this.volumeButton = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelPlayer);
            this.panelContainer.Controls.Add(this.panelControl);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(898, 595);
            this.panelContainer.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.pictureBuffer);
            this.panelPlayer.Controls.Add(this.backGround);
            this.panelPlayer.Controls.Add(this.axPlayer1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayer.Location = new System.Drawing.Point(0, 0);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(898, 534);
            this.panelPlayer.TabIndex = 1;
            // 
            // pictureBuffer
            // 
            this.pictureBuffer.AutoSize = true;
            this.pictureBuffer.Image = global::MyPlayer.Properties.Resources.loading;
            this.pictureBuffer.Location = new System.Drawing.Point(440, 214);
            this.pictureBuffer.MaximumSize = new System.Drawing.Size(50, 50);
            this.pictureBuffer.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBuffer.Name = "pictureBuffer";
            this.pictureBuffer.Size = new System.Drawing.Size(40, 40);
            this.pictureBuffer.TabIndex = 2;
            // 
            // backGround
            // 
            this.backGround.BackgroundImage = global::MyPlayer.Properties.Resources.back;
            this.backGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(898, 534);
            this.backGround.TabIndex = 1;
            this.backGround.TabStop = false;
            // 
            // axPlayer1
            // 
            this.axPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(898, 534);
            this.axPlayer1.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.Control;
            this.panelControl.Controls.Add(this.labelBuffer);
            this.panelControl.Controls.Add(this.PlayProgress);
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
            this.panelControl.TabIndex = 0;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            this.panelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseMove);
            // 
            // labelBuffer
            // 
            this.labelBuffer.AutoSize = true;
            this.labelBuffer.Location = new System.Drawing.Point(206, 31);
            this.labelBuffer.Name = "labelBuffer";
            this.labelBuffer.Size = new System.Drawing.Size(0, 12);
            this.labelBuffer.TabIndex = 19;
            // 
            // PlayProgress
            // 
            this.PlayProgress.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayProgress.Location = new System.Drawing.Point(0, 4);
            this.PlayProgress.Name = "PlayProgress";
            this.PlayProgress.Size = new System.Drawing.Size(50, 5);
            this.PlayProgress.TabIndex = 18;
            this.PlayProgress.TabStop = false;
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BarInnerColor = System.Drawing.Color.Gray;
            this.colorSlider1.BarOuterColor = System.Drawing.Color.Gray;
            this.colorSlider1.BarPenColor = System.Drawing.Color.Gray;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorSlider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.White;
            this.colorSlider1.ElapsedOuterColor = System.Drawing.Color.White;
            this.colorSlider1.Enabled = false;
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(0, 0);
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Size = new System.Drawing.Size(898, 12);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 17;
            this.colorSlider1.Text = "w";
            this.colorSlider1.ThumbInnerColor = System.Drawing.Color.Transparent;
            this.colorSlider1.ThumbOuterColor = System.Drawing.Color.Transparent;
            this.colorSlider1.ThumbPenColor = System.Drawing.Color.Transparent;
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSlider1.ThumbSize = 2;
            this.colorSlider1.Value = 1;
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
            this.setButton.MouseEnter += new System.EventHandler(this.setButton_MouseEnter);
            this.setButton.MouseLeave += new System.EventHandler(this.setButton_MouseLeave);
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
            this.scaleButton.MouseEnter += new System.EventHandler(this.scaleButton_MouseEnter);
            this.scaleButton.MouseLeave += new System.EventHandler(this.scaleButton_MouseLeave);
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
            this.volumeButton.MouseEnter += new System.EventHandler(this.volumeButton_MouseEnter);
            this.volumeButton.MouseLeave += new System.EventHandler(this.volumeButton_MouseLeave);
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
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FullScreen.png");
            this.imageList1.Images.SetKeyName(1, "FullScreenHover.png");
            this.imageList1.Images.SetKeyName(2, "Pause.png");
            this.imageList1.Images.SetKeyName(3, "PauseHover.png");
            this.imageList1.Images.SetKeyName(4, "Play.png");
            this.imageList1.Images.SetKeyName(5, "PlayHover.png");
            this.imageList1.Images.SetKeyName(6, "QuitFull.png");
            this.imageList1.Images.SetKeyName(7, "QuitFullHover.png");
            this.imageList1.Images.SetKeyName(8, "Set.png");
            this.imageList1.Images.SetKeyName(9, "SetHover.png");
            this.imageList1.Images.SetKeyName(10, "Volume.png");
            this.imageList1.Images.SetKeyName(11, "VolumeHover.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 595);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PlayerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PalyForm";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelPlayer;
        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox setButton;
        private System.Windows.Forms.PictureBox scaleButton;
        private MB.Controls.ColorSlider siliderVolume;
        private System.Windows.Forms.PictureBox volumeButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox playButton;
        private MB.Controls.ColorSlider colorSlider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayProgress;
        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.Label pictureBuffer;
        private System.Windows.Forms.Label labelBuffer;
    }
}