using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlayer
{
    public partial class MaskForm : Form
    {
        PlayerForm player = new PlayerForm();
        float time;
        public int a;
        public int b;
        public MaskForm()
        {
            InitializeComponent();
        }

        private void MaskForm_Load(object sender, EventArgs e)
        {
            this.Owner = player;
            player.Show();
            this.Controls.Add(this.maskPanel);
            this.maskPanel.Visible = false;
            a = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width)/2;
            b = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - this.Height)/2;
            player.playData.Top = b;
            player.playData.Left = a;
            this.Top = b;
            this.Left = a;
            player.Top = b;
            player.Left = a;
            this.playButton.Click += player.playButton_Click;
            this.playButton.MouseEnter += player.playButton_MouseEnter;
            this.playButton.MouseLeave += player.playButton_MouseLeave;
            this.playButton.MouseUp += player.playButton_MouseUp;
            this.volumeButton.MouseEnter += player.volumeButton_MouseEnter;
            this.volumeButton.MouseLeave += player.volumeButton_MouseLeave;
            this.setButton.MouseEnter += player.setButton_MouseEnter;
            this.setButton.MouseLeave += player.setButton_MouseLeave;
            this.scaleButton.MouseEnter += player.scaleButton_MouseEnter;
            this.scaleButton.MouseLeave += player.scaleButton_MouseLeave;
            this.MouseDown += player.panelControl_MouseDown;
            this.MouseMove += player.panelControl_MouseMove;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = player.player.GetDuration() / 100;
            this.Location = player.Location;
            if (player.player.GetPosition() > 0)
            {
                this.colorSlider1.Value = player.player.GetPosition() / (int)time;
            }
        }

        private void siliderVolume_Scroll(object sender, ScrollEventArgs e)
        {
            player.SiliderVolume(this.siliderVolume.Value);
        }

        private void MaskForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            player.PlayerButton();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (player.playData.isFullScreen)
                    {
                        player.EscKeyEvent();
                        this.panelControl.Visible = true;
                        this.Controls.Add(this.panelControl);
                        this.maskPanel.Visible = false;                        
                        this.Size = player.Size;
                    }   
                    break;
                case Keys.Space:
                    player.PlayerButton();
                    break;
                case Keys.Left:
                    player.KeyLeftEvent();
                    break;
                case Keys.Right:
                    player.KeyRightEvent();
                    break;
                case Keys.Up:
                    if (this.siliderVolume.Value < this.siliderVolume.Maximum)
                    {
                        this.siliderVolume.Value++;
                        player.SiliderVolume(this.siliderVolume.Value);
                    }           
                    break;
                case Keys.Down:
                    if (this.siliderVolume.Value > this.siliderVolume.Minimum)
                    {
                        this.siliderVolume.Value--;
                        player.SiliderVolume(this.siliderVolume.Value);
                    }
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            player.ScaleButton();
            this.panelControl.Visible = false;
            this.maskPanel.Visible = true;
            this.BringToFront();
            this.Size = player.Size;            
        }

        private void MaskForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {                
                case Keys.Left:
                    PlayerState();
                    break;
                case Keys.Right:
                    PlayerState();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 播放器当前状态
        /// </summary>
        private void PlayerState()
        {
            if (player.playData.playStatus == 0)
            {
                player.player.Pause();
            }
            else if(player.playData.playStatus == 1)
            {
                player.player.Play();
            }
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            player.PlaySlider(this.colorSlider1.Value);
        }

        private void MaskForm_DoubleClick(object sender, EventArgs e)
        {
            if (player.playData.isFullScreen)
            {
                player.EscKeyEvent();
                this.panelControl.Visible = true;
                this.Controls.Add(this.panelControl);
                this.maskPanel.Visible = false;
                this.Size = player.Size;
            }
            else
            {
                player.ScaleButton();
                this.panelControl.Visible = false;
                this.maskPanel.Visible = true;
                this.BringToFront();
                this.Size = player.Size;
            }
        }

        private void maskPanel_MouseEnter(object sender, EventArgs e)
        {
            player.ShowPanelControl(true);
            this.panelControl.Visible = true;
            this.maskPanel.Visible = false;
        }

        private void MaskForm_MouseEnter(object sender, EventArgs e)
        {
            if (player.playData.isFullScreen)
            {
                this.maskPanel.Visible = true;
                this.panelControl.Visible = false;
                player.ShowPanelControl(false);
            }
        }
    }
}
