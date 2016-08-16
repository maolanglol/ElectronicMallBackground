using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcYouJianMuBan_Insert
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
        #region 查询会员短信类型
        public DataTable ChaXunHuiYuanDuanJinLeiXing()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanDuanJinLeiXing";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcYouJianMuBan_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询会员用户名
        public DataTable ChaXunHuiYuanYongHuMing()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanYongHuMing";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcYouJianMuBan_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加邮件模板
        public int TianJiaYouJianMuBan(string strDiaoYongBieMing, string  strBiaoTi, string strYouJianBiaoTi ,string strXiTongMoRen                                     ) 
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@调用别名", SqlDbType.Char),
                                        new SqlParameter("@标题", SqlDbType.Char),
                                      new SqlParameter("@邮件标题", SqlDbType.Char),
                                        new SqlParameter("@系统默认", SqlDbType.Char),
                                   
                                             };

            SQlCMDpas[0].Value = "TianJiaYouJianMuBan";
            SQlCMDpas[1].Value = strDiaoYongBieMing;
            SQlCMDpas[2].Value = strBiaoTi;
            SQlCMDpas[3].Value = strYouJianBiaoTi;
            SQlCMDpas[4].Value = strXiTongMoRen;
        
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcYouJianMuBan_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
