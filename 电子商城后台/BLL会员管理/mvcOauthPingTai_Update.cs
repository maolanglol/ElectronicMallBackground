using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcOauthPingTai_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据会员类别ID查询会员类别信息
        public DataTable ChaXunOauthPingTai(int OauthID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@OauthID", SqlDbType.Int),
                                             };
            SQlCMDpas[0].Value = "ChaXunOauthPingTai";
            SQlCMDpas[1].Value = OauthID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcOauthPingTai_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 修改会员
        public int XiuGaiOauthPingTai(string strBiaoTi, string strMuLuMingCheng, string strMiaoShu, string strZhuangTai, int OauthID)
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                     
                                        new SqlParameter("@标题", SqlDbType.Char),
                                        new SqlParameter("@目录名称", SqlDbType.Char),
                                        new SqlParameter("@描述", SqlDbType.Char),
                                        new SqlParameter("@状态", SqlDbType.Char),
                                         new SqlParameter("@OauthID", SqlDbType.Int),
                                  
                                             };

            SQlCMDpas[0].Value = "XiuGaiOauthPingTai";
            SQlCMDpas[1].Value = strBiaoTi;
            SQlCMDpas[2].Value = strMuLuMingCheng;
            SQlCMDpas[3].Value = strMiaoShu;
            SQlCMDpas[4].Value = strZhuangTai;
            SQlCMDpas[5].Value = OauthID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcOauthPingTai_Update", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
