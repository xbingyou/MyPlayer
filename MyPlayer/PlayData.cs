using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlayer
{
    public class PlayData
    {
        public bool isFullScreen;//是否全屏
        public int playStatus;//播放状态 0暂停 1播放
        public string strPath;//播放路径
        public int Top;
        public int Left;
        public int Width;
        public int Height;     
        public PlayData()
        {
            strPath = "https://qiniu-xpc4.xpccdn.com/5b4748265cb29.mp4";
        }
    }
}
