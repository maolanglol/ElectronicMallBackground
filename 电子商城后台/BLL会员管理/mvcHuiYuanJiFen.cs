using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanJiFen
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有会员积分
        public DataTable ChaXunQuanBuHuiYuanJiFen()
        { 
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuHuiYuanJiFen";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanJiFen", SQlCMDpas);
            return dt;
        }
#endregion
        #region 模糊查询会员类别
        public DataTable MoHuChaXunHuiYuanJiFen(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunHuiYuanJiFen";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanJiFen", SQlCMDpas);
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
        public int ShanChuHuiYuanJiFen(int 会员积分ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@会员积分ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuHuiYuanJiFen";
            SQlCMDpas[1].Value = 会员积分ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanJiFen", SQlCMDpas);
            return i;
        }
        #endregion
    }
}
