using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcZhiFuFangShi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据支付方式类别ID查询支付方式类别信息
        public DataTable ChaXunZhiFuFangShi(int ZhiFuFangShiID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@支付方式ID", SqlDbType.Int),
                                             };
            SQlCMDpas[0].Value = "ChaXunZhiFuFangShi";
            SQlCMDpas[1].Value = ZhiFuFangShiID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcZhiFuFangShi_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 修改支付方式
    
        public int XiuGaiZhiFuFangShi(string strMingCheng, string strZhiFuMiaoShu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai,string strZhiFuFangShiID)
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@名称", SqlDbType.Char),
                                        new SqlParameter("@支付描述", SqlDbType.Char),
                                        new SqlParameter("@排序", SqlDbType.Int),
                                        new SqlParameter("@状态", SqlDbType.Char),
                                        new SqlParameter("@支付方式ID", SqlDbType.Int),
                                             };

            SQlCMDpas[0].Value = "XiuGaiZhiFuFangShi";
            SQlCMDpas[1].Value = strMingCheng;
            SQlCMDpas[2].Value = strZhiFuMiaoShu;
            SQlCMDpas[3].Value = Convert.ToInt32(strPaiXu);
            SQlCMDpas[4].Value = strZhuangTai;
            SQlCMDpas[5].Value = Convert.ToInt32(strZhiFuFangShiID);
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcZhiFuFangShi_Update", SQlCMDpas);
            return i;
        }
        #endregion
      
         
    }
}
