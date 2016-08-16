using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL基础数据
{
    public class mvcChanPinZiLiaoLeiBie
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询所有产品资料类别
        public DataTable ChaXunQuanBuWuLiaoLeiBie()
        { 
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "ChaXunQuanBuWuLiaoLeiBie";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing", SQlCMDpas);
            return dt;
        }
#endregion
        #region 模糊查询产品类别
        public DataTable MoHuChaXunWuLiaoLeiBie(string MoHuNeiRong)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@MoHuNeiRong", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "MoHuChaXunWuLiaoLeiBie";
            SQlCMDpas[1].Value = MoHuNeiRong;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 类型查询产品资料
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
        #region 查询所有商品类型
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
        #region 删除商品类别
        public int ShanChuWuLiaoLeiBie(int 商品类别ID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@WuLiaoLeiXingID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ShanChuWuLiaoLeiBie";
            SQlCMDpas[1].Value = 商品类别ID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing", SQlCMDpas);
            return i;
        }
        #endregion
            #region ID查询产品类别
        public DataTable IDChaXunWuLiaoLeiBie(int ID)
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                               new SqlParameter("@WuLiaoLeiXingID", SqlDbType.Int)
                                        };
            SQlCMDpas[0].Value = "IDChaXunWuLiaoLeiBie";
            SQlCMDpas[1].Value =ID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing", SQlCMDpas);
            return dt;
        }
        #endregion
        
    }
}
