using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanXinXi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有会员信息
        public DataTable ChaXunQuanBuHuiYuanXinXi()
        { 
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuHuanyuanXinXi";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanXinXi", SQlCMDpas);
            return dt;
        }
#endregion
        #region 模糊查询会员类别
        public DataTable MoHuChaXunHuiYuanXinXi(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunHuanYuanXinXi";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanXinXi", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 类型查询会员
        public DataTable LeiBieChaXunXinXi(int WuLiaoLeiXingID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@WuLiaoLeiXingID", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "LeiBieChaXunXinXi";
            SQlCMDpas[1].Value = WuLiaoLeiXingID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiao", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询所有会员类型
        public DataTable ChaXunWuLiaoLeiXing()
        {

            SqlParameter[] SQlCMDpas = { 
                                           new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunWuLiaoLeiXing";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiao", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 删除会员
        public int ShanChuHuiYuanXinXi(int 会员ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@会员ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuHuiYuanXinXi";
            SQlCMDpas[1].Value = 会员ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanXinXi", SQlCMDpas);
            return i;
        }
        #endregion
    }
}
