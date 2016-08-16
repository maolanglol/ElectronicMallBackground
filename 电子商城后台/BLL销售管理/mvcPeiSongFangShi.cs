using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcPeiSongFangShi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有配送方式信息
        public DataTable ChaXunQuanBuPeiSongFangShi()
        { 
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuPeiSongFangShi";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcPeiSongFangShi", SQlCMDpas);
            return dt;
        }
#endregion
        #region 模糊查询配送方式类别
        public DataTable MoHuChaXunPeiSongFangShi(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunPeiSongFangShi";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcPeiSongFangShi", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 类型查询配送方式
        public DataTable LeiBieChaXunXinXi(int WuLiaoLeiXingID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@WuLiaoLeiXingID", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "LeiBieChaXunXinXi";
            SQlCMDpas[1].Value = WuLiaoLeiXingID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询所有配送方式类型
        public DataTable ChaXunWuLiaoLeiXing()
        {

            SqlParameter[] SQlCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunWuLiaoLeiXing";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 删除配送方式
        public int ShanChuPeiSongFangShi(int 配送方式ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@配送方式ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuPeiSongFangShi";
            SQlCMDpas[1].Value = 配送方式ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcPeiSongFangShi", SQlCMDpas);
            return i;
        }
        #endregion
    }
}
