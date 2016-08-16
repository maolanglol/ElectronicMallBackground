using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanZuBie_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询仓库
        public DataTable ChaXunCangKu()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunCangKu";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询属性
        public DataTable ChaXunShuXing(int ShuXingJiHeID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@ShuXingJiHeID", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunShuXing";
            SQlCMDpas[1].Value = ShuXingJiHeID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询会员等级
        public DataTable ChaXunHuiYuanDengJi()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanDengJi";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanZuBie_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询会员等级
        public DataTable ChaXunHuiYuanZhuangTai()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanZhuangTai";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanZuBie_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加会员组别
        public int TianJiaHuiYuanZuBie(string strZuBieMingCheng, int intDengJiZhi, decimal decChuShiJinE, decimal decChuShiJiFen, decimal decGouWuZheKou
                                       ) 
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@组别名称", SqlDbType.Char),
                                        new SqlParameter("@等级值", SqlDbType.Int),
                                        new SqlParameter("@初始金额", SqlDbType.Money),
                                        new SqlParameter("@初始积分", SqlDbType.Decimal),
                                        new SqlParameter("@购物折扣", SqlDbType.Decimal),
                                     
                                         };

            SQlCMDpas[0].Value = "TianJiaHuiYuanZuBie";
            SQlCMDpas[1].Value = strZuBieMingCheng;
            SQlCMDpas[2].Value = intDengJiZhi;
            SQlCMDpas[3].Value = decChuShiJinE;
            SQlCMDpas[4].Value = decChuShiJiFen;
            SQlCMDpas[5].Value = decGouWuZheKou;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanZuBie_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
