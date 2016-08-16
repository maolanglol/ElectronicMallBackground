using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanXinXi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据会员类别ID查询会员类别信息
        public DataTable ChaXunHuiYuanXinXi(int HuiYuanXinXiID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@会员ID", SqlDbType.Int),
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanXinXi";
            SQlCMDpas[1].Value = HuiYuanXinXiID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanXinXi_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 修改会员
        public int XiuGaiHuiYuanXinXi(int strHuiYuanDengJiID, int strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua, string strShouJi, string strLianXiDiZhi,
                                     int intHuiYuanID
                                       )
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@会员等级PubID", SqlDbType.Int),
                                        new SqlParameter("@会员状态PubID", SqlDbType.Int),
                                    
                                        new SqlParameter("@会员用户名", SqlDbType.Char),
                                            new SqlParameter("@会员密码", SqlDbType.Char),
                                        new SqlParameter("@昵称", SqlDbType.Char),
                                        new SqlParameter("@邮箱", SqlDbType.Char),
                                        new SqlParameter("@性别", SqlDbType.Char),
                                        new SqlParameter("@QQ", SqlDbType.Char),
                                        new SqlParameter("@办公电话", SqlDbType.Char),
                                        new SqlParameter("@联系电话", SqlDbType.Char),
                                        new SqlParameter("@联系地址", SqlDbType.Char),
                                        new SqlParameter("@会员ID", SqlDbType.Char),
                         
                                             };

            SQlCMDpas[0].Value = "XiuGaiHuiYuanXinXi";
            SQlCMDpas[1].Value = strHuiYuanDengJiID;
            SQlCMDpas[2].Value = strHuiYuanZhuangTaiID;
            SQlCMDpas[3].Value = strYongHuMing;
            SQlCMDpas[4].Value = strMiMa;
            SQlCMDpas[5].Value = strNiCheng;
            SQlCMDpas[6].Value = strYouXiang;
            SQlCMDpas[7].Value = strXingBie;
            SQlCMDpas[8].Value = strQQ;
            SQlCMDpas[9].Value = strBanGongDianHua;
            SQlCMDpas[10].Value = strShouJi;
            SQlCMDpas[11].Value = strLianXiDiZhi;
            SQlCMDpas[12].Value = intHuiYuanID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanXinXi_Update", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
