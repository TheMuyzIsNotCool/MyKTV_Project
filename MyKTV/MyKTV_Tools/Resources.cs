using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV_Tools
{
    /// <summary>
    /// 资源项目类
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// 歌手图片文件路径
        /// </summary>
        public static string singerPicPath;
        /// <summary>
        /// 歌曲图片文件路径
        /// </summary>
        public static string SongPicPath;
        /// <summary>
        /// 歌曲文件路径
        /// </summary>
        public static string SongPath;

        /// <summary>
        /// 从数据库加载各文件夹路径到上面
        /// </summary>
        public static void InitResource()
        {
            string sqlstr = "select * from ResourceUrl";
            DBHelper.GetReader(sqlstr);
            while (DBHelper.dr.Read())
            {
                switch (DBHelper.dr["RName"].ToString())
                {
                    case "SingerPic":
                        singerPicPath = DBHelper.dr["RPath"].ToString();
                        break; 
                    case "SongPic":
                        SongPicPath = DBHelper.dr["RPath"].ToString();
                        break;
                    case "Song":
                        SongPath = DBHelper.dr["RPath"].ToString();
                        break;
                    default:
                        break;
                }
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }
    }
}
