using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcDingDanLieBiao
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有订单信息
        public DataTable ChaXunQuanBuDingDanLieBiao()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuDingDanLieBiao";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcDingDanLieBiao", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 模糊查询会员类别
        public DataTable MoHuChaXunDingDanLieBiao(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunDingDanLieBiao";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcDingDanLieBiao", SQlCMDpas);
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
        public int ShanChuDingDanLieBiao(int 订单ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@订单ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuDingDanLieBiao";
            SQlCMDpas[1].Value = 订单ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcDingDanLieBiao", SQlCMDpas);
            return i;
        }
        #endregion
    }
}
