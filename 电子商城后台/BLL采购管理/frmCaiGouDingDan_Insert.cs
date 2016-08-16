using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL采购管理
{

    public class frmCaiGouDingDan_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();


        public DataTable frmXinZengCaiGouDingDan_Load_SelectGongYingShang(string strMoHuGongYingShang)
        {
            #region 在frmXinZengCaiGouDingDan_Load事件中提取供应商
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             new SqlParameter("@strMoHuGongYingShang", SqlDbType.Char),
                                             };
            SQlCMDpas[0].Value = "frmXinZengCaiGouDingDan_Load_SelectGongYingShang";
            SQlCMDpas[1].Value = strMoHuGongYingShang;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return dt;
            #endregion
        }

        public DataTable frmXinZengCaiGouDingDan_Load_SelectChanPin(string strMoHuChanPin)
        {
            #region 在frmXinZengCaiGouDingDan_Load事件中提取产品
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char),
                                            new SqlParameter("@strMoHuChanPin", SqlDbType.Char),
                                        };
            SQlCMDpas[0].Value = "frmXinZengCaiGouDingDan_Load_SelectChanPin";
            SQlCMDpas[1].Value = strMoHuChanPin;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return dt;
            #endregion
        }

        public DataTable frmXinZengCaiGouDingDan_Load_SelectFuKuangFangShi()
        {
            #region 在frmXinZengCaiGouDingDan_Load事件中提取付款方式
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "frmXinZengCaiGouDingDan_Load_SelectFuKuangFangShi";

            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return dt;
            #endregion
        }

        public DataTable btnBaoCun_Click_SelectDangRiCaiGouDingDanZuiDaDanJuShu()
        {
            #region 在btnBaoCun_Click事件中提取当日最大采购订单单据数,用来生成采购订单号
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "btnBaoCun_Click_SelectDangRiCaiGouDingDanZuiDaDanJuShu";

            DataTable dt = myDALMethod.DAL_SelectDB_Par("更新当日最大单据数", SQlCMDpas);
            return dt;
            #endregion
        }

        public DataTable btnBaoCun_Click_SelectDingDanLeiXingJianCheng(int intDingDanLeiXingID)
        {
            #region 在btnBaoCun_Click事件中提取订单类型简称,用来生成采购订单号
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char),
                                            new SqlParameter("@DingDanLeiXingID", SqlDbType.Int )
                                        };
            SQlCMDpas[0].Value = "btnBaoCun_Click_SelectDingDanLeiXingJianCheng";
            SQlCMDpas[1].Value = intDingDanLeiXingID;

            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return dt;
            #endregion
        }
        public DataTable btnBaoCun_Click_InsertCaiGouDingDan(string strCaiGouDingDanBianHao, int intGongHuoShangID,
                                     int intFuKuanFangShiID, string strYuanShiDanHao, string strShengChanDanHao,
                                     DateTime dtXiaDanRiQi, DateTime dtJiaoHuoRiQi, decimal decYuFuDingJin,
                                     int intDingDanLeiXingID, decimal decYingFuJinE, int intShenHeYuanGongID,
                                     int intJingShouRenYuanGongID
                                     )
        {
            #region 在btnBaoCun_Click事件中保存采购订单
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char),
                                            new SqlParameter("@CaiGouDingDanBianHao", SqlDbType.Char ),
                                            new SqlParameter("@GongHuoShangID", SqlDbType.Int),
                                            new SqlParameter("@FuKuanFangShiID", SqlDbType.Int),
                                            new SqlParameter("@YuanShiDanHao", SqlDbType.Char),
                                            new SqlParameter("@ShengChanDanHao", SqlDbType.Char),
                                            new SqlParameter("@XiaDanRiQi", SqlDbType.Date ),
                                            new SqlParameter("@JiaoHuoRiQi", SqlDbType.Date),
                                            new SqlParameter("@YuFuDingJin", SqlDbType.Decimal ),
                                            new SqlParameter("@DingDanLeiXingID", SqlDbType.Int ),
                                            new SqlParameter("@YingFuJinE", SqlDbType.Decimal  ),
                                            new SqlParameter("@ShenHeYuanGongID", SqlDbType.Int ),
                                            new SqlParameter("@JingShouRenYuanGongID", SqlDbType.Int )
                                        };
            SQlCMDpas[0].Value = "btnBaoCun_Click_InsertCaiGouDingDan";
            SQlCMDpas[1].Value = strCaiGouDingDanBianHao;
            SQlCMDpas[2].Value = intGongHuoShangID;
            SQlCMDpas[3].Value = intFuKuanFangShiID;
            SQlCMDpas[4].Value = strYuanShiDanHao;
            SQlCMDpas[5].Value = strShengChanDanHao;
            SQlCMDpas[6].Value = dtXiaDanRiQi;
            SQlCMDpas[7].Value = dtJiaoHuoRiQi;
            SQlCMDpas[8].Value = decYuFuDingJin;
            SQlCMDpas[9].Value = intDingDanLeiXingID;
            SQlCMDpas[10].Value = decYingFuJinE;
            SQlCMDpas[11].Value = intShenHeYuanGongID;
            SQlCMDpas[12].Value = intJingShouRenYuanGongID;

            DataTable mydt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return mydt;
            #endregion
        }

        public int btnBaoCun_Click_InsertCaiGouDingDanMingXi(int intCaiGouDingDanID, int intWuLiaoID, decimal decShuLiang,
                                                             decimal decDanJia, Double ShuiLvf, string strBeiZhu, int intShuXingMingXiPubID)
        {
            #region 在btnBaoCun_Click事件中保存采购订单明细
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char),
                                            new SqlParameter("@CaiGouDingDanID", SqlDbType.Int ),
                                            new SqlParameter("@WuLiaoID", SqlDbType.Int ),
                                            new SqlParameter("@ShuLiang", SqlDbType.Decimal  ),
                                            new SqlParameter("@DanJia", SqlDbType.Decimal  ),
                                            new SqlParameter("@ShuiLv", SqlDbType.Float),
                                            new SqlParameter("@BeiZhu", SqlDbType.Char  ),
                                            new SqlParameter("@ShuXingMingXiPubID", SqlDbType.Char  )
                                        };
            SQlCMDpas[0].Value = "btnBaoCun_Click_InsertCaiGouDingDanMingXi";
            SQlCMDpas[1].Value = intCaiGouDingDanID;
            SQlCMDpas[2].Value = intWuLiaoID;
            SQlCMDpas[3].Value = decShuLiang;
            SQlCMDpas[4].Value = decDanJia;
            SQlCMDpas[5].Value = ShuiLvf;
            SQlCMDpas[6].Value = strBeiZhu;
            SQlCMDpas[7].Value = intShuXingMingXiPubID;

            int myint = myDALMethod.DAL_OPTableDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return myint;
            #endregion
        }

        public DataTable frmXinZengCaiGouDingDan_Load_SelectYanSe()
        {
            #region 在frmXinZengCaiGouDingDan_Load事件中提取颜色
            SqlParameter[] SQlCMDpas = {
                                            new SqlParameter("@Type", SqlDbType.Char)                                           
                                        };
            SQlCMDpas[0].Value = "frmXinZengCaiGouDingDan_Load_SelectYanSe";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDan_Insert", SQlCMDpas);
            return dt;
            #endregion
        }
    }
}
