using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL基础数据
{
    public class mvcChanPinZiLiaoLeiBie_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
       
        #region 根据商品类别ID查询商品类别信息
        public DataTable ChaXunWuLiaoLeiBie(int WuLiaoLeiXingID)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                                new SqlParameter("@类别ID", SqlDbType.Int),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunWuLiaoLeiBie";
            SQlCMDpas[1].Value = WuLiaoLeiXingID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing_Update", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 修改商品
        public int XiuGaiWuLiao(int 类别ID,
                                string 类别名称,
                                int 父级ID,
                                string 调用别名
                             )
          {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@类别ID", SqlDbType.Int),
                                        new SqlParameter("@类别名称", SqlDbType.Char),
                                        new SqlParameter("@调用别名", SqlDbType.NChar),
                                        new SqlParameter("@父级ID", SqlDbType.Int),
                                    
                                             };

            SQlCMDpas[0].Value = "XiuGaiWuLiaoLeiBie";
            SQlCMDpas[1].Value = 类别ID;
            SQlCMDpas[2].Value = 类别名称;
            SQlCMDpas[3].Value = 调用别名;
            SQlCMDpas[4].Value = 父级ID;

            int i = myDALMethod.DAL_OPTableDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing_Update", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
