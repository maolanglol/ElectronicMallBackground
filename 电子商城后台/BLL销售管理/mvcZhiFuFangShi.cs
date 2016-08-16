using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcZhiFuFangShi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有支付方式信息
        public DataTable ChaXunQuanBuZhiFuFangShi()
        { 
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuZhiFuFangShi";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcZhiFuFangShi", SQlCMDpas);
            return dt;
        }
#endregion
        #region 模糊查询支付方式类别
        public DataTable MoHuChaXunZhiFuFangShi(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunZhiFuFangShi";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcZhiFuFangShi", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 类型查询支付方式
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
        #region 查询所有支付方式类型
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
        #region 删除支付方式
        public int ShanChuZhiFuFangShi(int 支付方式ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@支付方式ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuZhiFuFangShi";
            SQlCMDpas[1].Value = 支付方式ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcZhiFuFangShi", SQlCMDpas);
            return i;
        }
        #endregion
    }
}
