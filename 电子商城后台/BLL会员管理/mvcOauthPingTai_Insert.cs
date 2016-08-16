using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcOauthPingTai_Insert
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcOauthPingTai_Insert", SQlCMDpas);
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcOauthPingTai_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加会员
        public int TianJiaOauthPingTai(string strBiaoTi, string strMuLuMingCheng, string strMiaoShu, string strZhuangTai             ) 
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                     
                                        new SqlParameter("@标题", SqlDbType.Char),
                                        new SqlParameter("@目录名称", SqlDbType.Char),
                                        new SqlParameter("@描述", SqlDbType.Char),
                                        new SqlParameter("@状态", SqlDbType.Char),
                                  
                                             };

            SQlCMDpas[0].Value = "TianJiaOauthPingTai";
            SQlCMDpas[1].Value = strBiaoTi;
            SQlCMDpas[2].Value = strMuLuMingCheng;
            SQlCMDpas[3].Value = strMiaoShu;
            SQlCMDpas[4].Value = strZhuangTai;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcOauthPingTai_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
