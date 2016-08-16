using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcPeiSongFangShi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据配送方式类别ID查询配送方式类别信息
        public DataTable ChaXunPeiSongFangShi(int PeiSongFangShiID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@配送方式ID", SqlDbType.Int),
                                             };
            SQlCMDpas[0].Value = "ChaXunPeiSongFangShi";
            SQlCMDpas[1].Value = PeiSongFangShiID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcPeiSongFangShi_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 修改配送方式
        public int XiuGaiPeiSongFangShi(string strBiaoTi, string strBeiZhu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai,string strPeiSongFangShiID)
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@标题", SqlDbType.Char),
                                        new SqlParameter("@备注", SqlDbType.Char),
                                        new SqlParameter("@配送费用", SqlDbType.Money),
                                        new SqlParameter("@排序", SqlDbType.Int),
                                        new SqlParameter("@状态", SqlDbType.Char),
                                        new SqlParameter("@配送方式ID", SqlDbType.Char),
                                             };

            SQlCMDpas[0].Value = "XiuGaiPeiSongFangShi";
            SQlCMDpas[1].Value = strBiaoTi;
            SQlCMDpas[2].Value = strBeiZhu;
            SQlCMDpas[3].Value = Convert.ToDecimal(strPeiSongFeiYong);
            SQlCMDpas[4].Value = Convert.ToInt32(strPaiXu);
            SQlCMDpas[5].Value = strZhuangTai;
            SQlCMDpas[6].Value = Convert.ToInt32(strPeiSongFangShiID);
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcPeiSongFangShi_Update", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
