using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcPeiSongFangShi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询仓库
        public DataTable ChaXunCangKu()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunCangKu";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao_Insert", SQlCMDpas);
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao_Insert", SQlCMDpas);
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcPeiSongFangShi_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询支付方式
        public DataTable ChaXunHuiYuanZhuangTai()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanZhuangTai";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcPeiSongFangShi_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加支付方式
        public int TianJiaPeiSongFangShi(string strMingCheng, string strZhiFuMiaoShu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai) 
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@标题", SqlDbType.Char),
                                        new SqlParameter("@备注", SqlDbType.Char),
                                        new SqlParameter("@配送费用", SqlDbType.Int),
                                        new SqlParameter("@排序", SqlDbType.Int),
                                        new SqlParameter("@状态", SqlDbType.Char),
                   
                                             };

            SQlCMDpas[0].Value = "TianJiaPeiSongFangShi";
            SQlCMDpas[1].Value = strMingCheng;
            SQlCMDpas[2].Value =strZhiFuMiaoShu;
            SQlCMDpas[3].Value =Convert.ToDecimal( strPeiSongFeiYong);
            SQlCMDpas[4].Value =Convert.ToInt32( strPaiXu);
            SQlCMDpas[5].Value = strZhuangTai;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcPeiSongFangShi_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
