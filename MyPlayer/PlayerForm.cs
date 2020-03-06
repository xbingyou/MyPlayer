using AxAPlayer3Lib;
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
    public partial class PlayerForm : Form
    {
        public PlayData playData = new PlayData();
        public AxPlayer player;
        public Size fsize = new Size(898, 595);
        float time;
        int speedTime;//快进时间
        Point mouseOffset;//鼠标偏移值
        public PlayerForm()
        {
            InitializeComponent();
            player = this.axPlayer1;
        }
        
        private void PlayerForm_Load(object sender, EventArgs e)
        {
            this.axPlayer1.Open(playData.strPath);//打开文件
            //this.axPlayer1.SetConfig(120,"1");//设置不自动关闭
            axPlayer1.OnOpenSucceeded += AxPlayer1_OnOpenSucceeded;
            axPlayer1.OnBuffer += AxPlayer1_OnBuffer;            
        }
         
        private void AxPlayer1_OnOpenSucceeded(object sender, EventArgs e)
        {
            this.labelBuffer.Text = "正在播放";
            playData.playStatus = 1;
            this.axPlayer1.Play();
            this.backGround.Visible = false;
            this.pictureBuffer.Visible = false;
        }
        private void AxPlayer1_OnBuffer(object sender, _IPlayerEvents_OnBufferEvent e)
        {
            if (e.nPercent != 100)
            {
                this.labelBuffer.Text = string.Format("正在缓冲...{0}%", e.nPercent);
                this.backGround.Visible = true;
                this.pictureBuffer.Visible = true;
            }
            else
            {
                this.labelBuffer.Text = "正在播放";
                this.backGround.Visible = false;
                this.pictureBuffer.Visible = false;
            }
        }


        public void playButton_Click(object sender, EventArgs e)
        {
            
        }
        public void playButton_MouseEnter(object sender, EventArgs e)
        {
            switch (playData.playStatus)
            {
                case 0:
                    ImageChange("PauseHover");
                    break;
                case 1:
                    ImageChange("PlayHover");
                    break;
                default:
                    break;
            }
        }

        public void playButton_MouseLeave(object sender, EventArgs e)
        {
            switch (playData.playStatus)
            {
                case 0:
                    ImageChange("Pause");
                    break;
                case 1:
                    ImageChange("Play");
                    break;
                default:
                    break;
            }
        }
        public void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            PlayerButton();
        }
        /// <summary>
        /// 点击屏幕暂停播放
        /// </summary>
        public void PlayerButton()
        {
            switch (playData.playStatus)
            {
                case 0:
                    axPlayer1.Play();
                    this.labelBuffer.Text = "正在播放";
                    ImageChange("Play");
                    playData.playStatus = 1;
                    break;
                case 1:
                    axPlayer1.Pause();
                    this.labelBuffer.Text = "已暂停";
                    ImageChange("Pause");
                    playData.playStatus = 0;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 更换图片
        /// </summary>
        /// <param name="str"></param>
        public void ImageChange(string str)
        {
            this.playButton.Image = this.imageList1.Images[str + ".png"];                
        }

        public void scaleButton_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 缩放按钮事件
        /// </summary>
        public void ScaleButton()
        {
            if (!playData.isFullScreen)
            {
                this.scaleButton.Image = this.imageList1.Images["QuitFull.png"];
                this.panelControl.Visible=false;
                this.axPlayer1.Controls.Add(this.panelControl);                
                this.Top = Screen.PrimaryScreen.Bounds.Top;
                this.Left = Screen.PrimaryScreen.Bounds.Left;
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                this.pictureBuffer.Location = new Point(950, 450);
                playData.isFullScreen = true;
            }
            else
            {
                EscKeyEvent();
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            time = (float)axPlayer1.GetDuration() / (float)this.panelControl.Width;
            this.labelTime.Text = TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetPosition()))
                + "/" + TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetDuration()));//毫秒的时间转换
            if (time > 0 && this.PlayProgress.Width<this.panelControl.Width)
            {
                this.PlayProgress.Width = this.axPlayer1.GetPosition() / (int)time;
            }
            if (axPlayer1.GetConfig(7).ToString().Equals(0.ToString()))
            {
                this.backGround.Visible = true;
                this.labelBuffer.Text = "播放完毕";
            }
        }

        /// <summary>
        /// 播放进度条
        /// </summary>
        public void PlaySlider(int sliderValue)
        {
            axPlayer1.SetPosition(this.axPlayer1.GetDuration()/100*sliderValue);
        }
        /// <summary>
        /// 时间格式转换
        /// </summary>
        public string TimeToString(TimeSpan span)
        {
            return span.Hours.ToString("00") + ":" +
            span.Minutes.ToString("00") + ":" +
            span.Seconds.ToString("00");
        }

        public void volumeButton_MouseEnter(object sender, EventArgs e)
        {            
            this.volumeButton.Image = this.imageList1.Images["VolumeHover.png"];
        }

        public void volumeButton_MouseLeave(object sender, EventArgs e)
        {
            this.volumeButton.Image = this.imageList1.Images["Volume.png"];
        }

        public void scaleButton_MouseEnter(object sender, EventArgs e)
        {
            if (playData.isFullScreen)
            {
                this.scaleButton.Image = this.imageList1.Images["QuitFullHover.png"];
            }
            else
            {
                this.scaleButton.Image = this.imageList1.Images["FullScreenHover.png"];
            }
        }

        public void scaleButton_MouseLeave(object sender, EventArgs e)
        {
            if (playData.isFullScreen)
            {
                this.scaleButton.Image = this.imageList1.Images["QuitFull.png"];
            }
            else
            {
                this.scaleButton.Image = this.imageList1.Images["FullScreen.png"];
            }
        }

        public void setButton_MouseEnter(object sender, EventArgs e)
        {
            this.setButton.Image = this.imageList1.Images["SetHover.png"];
        }

        public void setButton_MouseLeave(object sender, EventArgs e)
        {
            this.setButton.Image = this.imageList1.Images["Set.png"];
        }

        /// <summary>
        /// 声音滑动条
        /// </summary>
        /// <param name="value"></param>
        public void SiliderVolume(int value)
        {
            axPlayer1.SetVolume(value);//声音滑动条
            this.siliderVolume.Value = value;
        }

        /// <summary>
        /// ESC按键缩放事件
        /// </summary>
        public void EscKeyEvent()
        {
            this.PlayProgress.Width = this.PlayProgress.Width / 2;
            this.panelControl.Visible = true;
            this.scaleButton.Image = this.imageList1.Images["FullScreen.png"];
            this.Controls.Add(this.panelControl);
            this.Size = fsize;
            this.Top = playData.Top;
            this.Left = playData.Left;
            this.pictureBuffer.Location = new Point(440, 200);
            playData.isFullScreen = false;
        }
        /// <summary>
        /// 按键左键快退事件
        /// </summary>
        public void KeyLeftEvent()
        {
            axPlayer1.SetConfig(113, "-20");
        }
        /// <summary>
        /// 按键右键快进事件
        /// </summary>
        public void KeyRightEvent()
        {
            if (axPlayer1.GetPosition()+50 < axPlayer1.GetDuration())
            {
                speedTime += 50;
                axPlayer1.SetPosition(axPlayer1.GetPosition() + speedTime);
            }            
        }
        
        public void ShowPanelControl(bool isShow)
        {
            this.panelControl.Visible = isShow;
        }

        public void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new Point(-e.X, -e.Y);
        }
        //窗口拖动
        public void panelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !playData.isFullScreen)
            {
                axPlayer1.Pause();
                this.labelBuffer.Text = "已暂停";
                ImageChange("Pause");
                playData.playStatus = 1;
                Point pointPosition = Control.MousePosition;
                pointPosition.Offset(mouseOffset);
                this.Location = pointPosition;
            }
        }
    }
}
