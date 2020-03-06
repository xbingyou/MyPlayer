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
    public partial class Form1 : Form
    {
        float time;
        PlayData playData = new PlayData();
        //Form myForm = new Form();
        //Sunisoft.IrisSkin.SkinEngine se = null;
        Size fsize = new Size(960, 540);

        public Form1()
        {
            InitializeComponent();            
            this.axPlayer1.Open("http://192.168.1.126:8888/group1/M00/00/00/wKgBflnpnd2AbhvoF-ME6Z1wwWk438.mp4");//打开文件
            this.PauseBtn.Visible = true;
            this.PlayBtn.Visible = false;           
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            this.axPlayer1.Play();//播放
            this.PauseBtn.Visible = true;
            this.PlayBtn.Visible = false;
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            this.axPlayer1.Pause();//暂停
            this.PlayBtn.Visible = true;
            this.PauseBtn.Visible = false;            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ////2463800
            ////944
            ////15
            //d = this.trackBar1.Value*24638;
            //double a = this.axPlayer1.GetPosition();
            //double b = this.axPlayer1.GetDuration();
            //this.axPlayer1.SetPosition(d);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetPosition()))
                +"/"+TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetDuration()));//毫秒的时间转换
            time = (float)axPlayer1.GetDuration() / 100f;
            if (time > 0)
            {
                this.colorSlider2.Value = this.axPlayer1.GetPosition() / (int)time;
            }                      
        }

        /// <summary>
        /// 时间格式转换
        /// </summary>
        string TimeToString(TimeSpan span)
        {
            return span.Hours.ToString("00") + ":" +
            span.Minutes.ToString("00") + ":" +
            span.Seconds.ToString("00");
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            this.axPlayer1.SetVolume(this.colorSlider1.Value);//声音滑动条进度
            
        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            axPlayer1.SetPosition(this.colorSlider2.Value*(int)time);//播放滑动条进度
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!playData.isFullScreen)
            {
                this.panel1.Hide();
                this.PlayBtn.Hide();
                this.PauseBtn.Hide();
                this.colorSlider1.Hide();
                this.colorSlider2.Hide();
                this.pictureBox3.Hide();
                this.label1.Hide();
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                playData.isFullScreen = true;
                //playData.Top = axPlayer1.Top;
                //playData.Left = axPlayer1.Left;
                //playData.Width = axPlayer1.Width;
                //playData.Height = axPlayer1.Height;
                //playData.isScreen = true;
                //this.pictureBox4.Visible = true;
                //this.pictureBox4.Parent = myForm;
                //myForm.Width = Screen.PrimaryScreen.Bounds.Width;
                //myForm.Height = Screen.PrimaryScreen.Bounds.Height;
                //myForm.FormBorderStyle = FormBorderStyle.None;
                //axPlayer1.Parent = myForm;                
                //myForm.Show();
                //axPlayer1.Top = 0;
                //axPlayer1.Left = 0;
                //axPlayer1.Width = Screen.PrimaryScreen.Bounds.Width;
                //axPlayer1.Height = Screen.PrimaryScreen.Bounds.Height;
            }
            else
            {
                this.panel1.Show();
                foreach (Control item in this.panel1.Controls)
                {
                    item.Show();
                }
                this.Size =fsize;
                playData.isFullScreen = false;
                axPlayer1.Size = fsize;
            }
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayBtn_MouseEnter(object sender, EventArgs e)
        {
            this.PlayBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\播放 -01悬停.png");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath+ "\\Picture\\全屏显示.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\全屏显示(1).png");
        }

        private void PlayBtn_MouseLeave(object sender, EventArgs e)
        {
            this.PlayBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\播放 -01(1).png");
        }

        private void PauseBtn_MouseEnter(object sender, EventArgs e)
        {
            this.PauseBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\暂停播放.png");
        }

        private void PauseBtn_MouseLeave(object sender, EventArgs e)
        {
            this.PauseBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\暂停播放(1).png");
        }

        private void SetBtn_MouseEnter(object sender, EventArgs e)
        {
            this.SetBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\设置.png");
        }

        private void SetBtn_MouseLeave(object sender, EventArgs e)
        {
            this.SetBtn.Image = Image.FromFile(Application.StartupPath + "\\Picture\\设置(1).png");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\Picture\\音量 (1).png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\Picture\\音量 .png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //axPlayer1.Parent = this;
            //this.panel1.Parent = this;
            //axPlayer1.Dock = DockStyle.Top;
            //axPlayer1.Top = playData.Top;
            //axPlayer1.Left = playData.Left;
            //axPlayer1.Width = playData.Width;
            //axPlayer1.Height = playData.Height;
            //playData.isScreen = false;            
            //myForm.Hide();
        }

   

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ss = '\u001b';//Esc键
            if (ss.Equals(e.KeyChar))
            {
                this.panel1.Show();
                foreach (Control item in this.panel1.Controls)
                {
                    item.Show();
                }
                this.Size = fsize;
                playData.isFullScreen = false;
                axPlayer1.Size = fsize;
            }
            System.Console.WriteLine(e.KeyChar);
            //mask.StartPosition = FormStartPosition.CenterScreen;
            //mask.Location = this.Location;
            //mask.Size = this.Size;
            //mask.FormBorderStyle = FormBorderStyle.None;
            //mask.Opacity = 0.01;
            //mask.TopMost = true;

            //mask.KeyPreview = true;
            //mask.Show();
        }
    }
}