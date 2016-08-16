using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL基础数据
{
 public  class mvcChanPinZiLiao_Insert
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
                  public int TianJiaWuLiao( string 商品编码,
                                            string 商品名称,
                                            int 商品类别PubID,
                                            string 助记码,
                                            string 条形码,
                                            int 生产商ID,
                                            int 计量单位PubID,
                                            string 规格,
                                            int 颜色PubID,
                                            int 默认仓库ID,
                                            string 默认储位,
                                            bool 打折否,
                                            decimal 预设进价,
                                            decimal VIP价格,
                                            decimal 会员价格,
                                            decimal 限售建议价格,
                                            string 备注)
        {

            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@商品编码", SqlDbType.Char),
                                        new SqlParameter("@商品名称", SqlDbType.Char),
                                        new SqlParameter("@商品类别PubID", SqlDbType.Int),
                                        new SqlParameter("@助记码", SqlDbType.Char),
                                        new SqlParameter("@条形码", SqlDbType.Char),
                                        new SqlParameter("@生产商ID", SqlDbType.Int),
                                        new SqlParameter("@计量单位PubID", SqlDbType.Int),
                                        new SqlParameter("@规格", SqlDbType.Char),
                                        new SqlParameter("@颜色PubID", SqlDbType.Int),
                                        new SqlParameter("@默认仓库ID", SqlDbType.Int),
                                        new SqlParameter("@默认储位", SqlDbType.Char),
                                        new SqlParameter("@打折否", SqlDbType.Bit),
                                        new SqlParameter("@预设进价", SqlDbType.Decimal),
                                        new SqlParameter("@VIP价格", SqlDbType.Decimal),
                                        new SqlParameter("@会员价格", SqlDbType.Decimal),
                                        new SqlParameter("@限售建议价格", SqlDbType.Decimal),
                                        new SqlParameter("@备注", SqlDbType.Text),
                                          
                                             };

            SQlCMDpas[0].Value = "TianJiaWuLiao";
            SQlCMDpas[1].Value = 商品编码 ;
            SQlCMDpas[2].Value = 商品名称 ;
            SQlCMDpas[3].Value =  商品类别PubID ;
            SQlCMDpas[4].Value =  助记码;
            SQlCMDpas[5].Value =  条形码;
            SQlCMDpas[6].Value =  生产商ID;
            SQlCMDpas[7].Value = 计量单位PubID;
            SQlCMDpas[8].Value = 规格 ;
            SQlCMDpas[9].Value = 颜色PubID ;
            SQlCMDpas[10].Value = 默认仓库ID ;
            SQlCMDpas[11].Value =  默认储位;
            SQlCMDpas[12].Value = 打折否 ;
            SQlCMDpas[13].Value = 预设进价 ;
            SQlCMDpas[14].Value = VIP价格 ;
            SQlCMDpas[15].Value = 会员价格 ;
            SQlCMDpas[16].Value = 限售建议价格;
            SQlCMDpas[17].Value = 备注;
            int i = myDALMethod.DAL_OPTableDB_Par("UIL基础数据_mvcChanPinZiLiao_Insert", SQlCMDpas);
            return i;
        }
        #endregion
         
    }
}
