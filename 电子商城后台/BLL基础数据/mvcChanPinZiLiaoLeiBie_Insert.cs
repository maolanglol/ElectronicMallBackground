using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL基础数据
{
    public class mvcChanPinZiLiaoLeiBie_Insert
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
        #region 查询生产商
        public DataTable ChaXunChangShang()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunChangShang";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL基础数据_mvcChanPinZiLiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加商品
        public int TianJiaWuLiaoLeiBie(int 父级ID,
                                            string 类别名称,
                                            string 调用别名
                                       )
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@父级ID", SqlDbType.Int),
                                        new SqlParameter("@类别名称", SqlDbType.Char),
                                        new SqlParameter("@调用别名", SqlDbType.Char),
                                   
                                             };

            SQlCMDpas[0].Value = "TianJiaWuLiaoLeiBie";
            SQlCMDpas[1].Value = 父级ID;
            SQlCMDpas[2].Value = 类别名称;
            SQlCMDpas[3].Value = 调用别名;

            int i = myDALMethod.DAL_OPTableDB_Par("UIL基础数据_mvcChanPinZiLiaoLeiXing_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
