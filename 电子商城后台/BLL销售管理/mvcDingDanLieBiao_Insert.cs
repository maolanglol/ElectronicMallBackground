using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL销售管理
{
    public class mvcDingDanLieBiao_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 查询仓库
        public DataTable ChaXunCangKu()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunCangKu";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao_Insert", SQlCMDpas);
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
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcChanPinZiLiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询会员等级
        public DataTable ChaXunHuiYuanDengJi()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanDengJi";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcDingDanLieBiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 查询会员等级
        public DataTable ChaXunHuiYuanZhuangTai()
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                          
                                             };
            SQlCMDpas[0].Value = "ChaXunHuiYuanZhuangTai";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL销售管理_mvcDingDanLieBiao_Insert", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 添加会员
        public int TianJiaDingDanLieBiao(int strHuiYuanDengJiID, int strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua, string strShouJi, string strLianXiDiZhi
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
                         
                                             };

            SQlCMDpas[0].Value = "TianJiaDingDanLieBiao";
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
            int i = myDALMethod.DAL_OPTableDB_Par("UIL销售管理_mvcDingDanLieBiao_Insert", SQlCMDpas);
            return i;
        }
        #endregion

    }
}
