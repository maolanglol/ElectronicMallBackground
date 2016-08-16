using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanDuanXin_Insert
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanDuanXin_Insert", SQlCMDpas);
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanDuanXin_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加会员
        public int TianJiaHuiYuanDuanXin(int strDuanXinLeiXingID, int strYongHuMingID, string strBiaoTi                                       ) 
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@类型ID", SqlDbType.Int),
                                        new SqlParameter("@收件人", SqlDbType.Int),
                                   
                                        new SqlParameter("@标题", SqlDbType.Char),
                                       
                                             };

            SQlCMDpas[0].Value = "TianJiaHuiYuanDuanXin";
            SQlCMDpas[1].Value = strDuanXinLeiXingID;
            SQlCMDpas[2].Value = strYongHuMingID;
            SQlCMDpas[3].Value = strBiaoTi;
        
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanDuanXin_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
