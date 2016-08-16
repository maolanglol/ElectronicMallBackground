using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL会员管理
{
    public class mvcHuiYuanZuBie_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据会员类别ID查询会员类别信息
        public DataTable ChaXunHuiYuanZuBie(int HuiYuanZuBieID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@组别ID", SqlDbType.Int),
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanZuBie";
            SQlCMDpas[1].Value = HuiYuanZuBieID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL会员管理_mvcHuiYuanZuBie_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加会员组别
        public int XiuGaiHuiYuanZuBie(string strZuBieMingCheng, int intDengJiZhi, decimal decChuShiJinE, decimal decChuShiJiFen, decimal decGouWuZheKou,int intZuBieID
                                       )
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@组别名称", SqlDbType.Char),
                                        new SqlParameter("@等级值", SqlDbType.Int),
                                        new SqlParameter("@初始金额", SqlDbType.Money),
                                        new SqlParameter("@初始积分", SqlDbType.Decimal),
                                        new SqlParameter("@购物折扣", SqlDbType.Decimal),
                                          new SqlParameter("@组别ID", SqlDbType.Int),
                                     
                                         };

            SQlCMDpas[0].Value = "XiuGaiHuiYuanZuBie";
            SQlCMDpas[1].Value = strZuBieMingCheng;
            SQlCMDpas[2].Value = intDengJiZhi;
            SQlCMDpas[3].Value = decChuShiJinE;
            SQlCMDpas[4].Value = decChuShiJiFen;
            SQlCMDpas[5].Value = decGouWuZheKou;
            SQlCMDpas[6].Value = intZuBieID;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL会员管理_mvcHuiYuanZuBie_Update", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
