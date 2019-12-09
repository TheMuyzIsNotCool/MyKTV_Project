using MyKTV_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV_Client
{
    public partial class frmaxWMP : Form
    {
        public frmaxWMP()
        {
            InitializeComponent();
        }
        //初始化VLC播放器
        public VlcPlayer.VlcPlayerBase VlcPlayerBase = new VlcPlayer.VlcPlayerBase(Environment.CurrentDirectory + "\\vlc\\plugins\\");

        /// <summary>
        /// 当前正在播放的歌曲
        /// </summary>
        public Sound songs;

        /// <summary>
        /// 重唱功能
        /// </summary>
        public void RelSong()
        {
            
            VlcPlayerBase.SetRenderWindow(this.pictureBox1.Handle.ToInt32());
            VlcPlayerBase.LoadFile(Resources.SongPath + "\\" + song[index].Url);
            VlcPlayerBase.Play();
        }

        /// <summary>
        /// 已点歌曲列表
        /// 默认当前每个元素值都是NULL
        /// </summary>
        public Sound[] song = new Sound[50];

        /// <summary>
        /// 确认当前播放的歌曲索引
        /// </summary>
        public int index = 0;

        /// <summary>
        /// 切歌功能
        /// </summary>
        public void NextSong()
        {
            //当前歌曲改为已播放
            song[index].SongState = 2;
            //当前歌曲是最后一首歌,则重复播放
            if (index != (song.Length - 1) || song[index + 1] != null)
            {
                //获取已点歌曲的下一个索引
                index++;
            }
            //

            
            VlcPlayerBase.SetRenderWindow(this.pictureBox1.Handle.ToInt32());
            VlcPlayerBase.LoadFile(Resources.SongPath + "\\" + song[index].Url);
            VlcPlayerBase.Play();
        }  

        private void frmaxWMP_Load(object sender, EventArgs e)
        {
            string sqlStr = "select SongID,SongName,SingerName,Url,a.SingerID from Song a, Singer b where a.SingerID = b.SingerID ";
            DBHelper.GetReader(sqlStr);
            while (DBHelper.dr.Read())
            {

                Sound s = new Sound();
                s.SongID = (int)DBHelper.dr["SongID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.SingerID = (int)DBHelper.dr["SingerID"];

                s.Url = DBHelper.dr["Url"].ToString();

                s.SongState = 0; //状态设置为未播放
                    //将歌曲存入数组
                song[index] = s;
                index++;
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
            //将要播放的歌曲索引改为第一首
            index = 0;
            //播放第一首歌
            song[index].SongState = 1;
           
            VlcPlayerBase.SetRenderWindow(this.pictureBox1.Handle.ToInt32());
            VlcPlayerBase.LoadFile(Resources.SongPath + "\\" + song[index].Url);
            VlcPlayerBase.Play();

        }
    }
}
