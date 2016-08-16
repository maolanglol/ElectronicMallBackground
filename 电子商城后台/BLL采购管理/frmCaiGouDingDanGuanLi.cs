using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL采购管理
{
    public class frmCaiGouDingDanGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();
        #region 在frmXinZengCaiGouDingDan_Load事件中提取供应商
        public DataTable btnChaXun_Click_SelectCaiGouDingDan(DateTime dtKaiShiShiJian, DateTime dtJieShuShiJian)
        {

            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char),
                                             //new SqlParameter("@CaiGouDingDanBianHao", SqlDbType.Char),
                                             //new SqlParameter("@GongHuoShangMingCheng", SqlDbType.Char),
                                             new SqlParameter("@KaiShiShiJian", SqlDbType.DateTime ),
                                             new SqlParameter("@JieShuShiJian", SqlDbType.DateTime)
                                             };
            SQlCMDpas[0].Value = "btnChaXun_Click_SelectCaiGouDingDan";
            //SQlCMDpas[1].Value = strCaiGouDingDanBianHao;
            //SQlCMDpas[2].Value = GongHuoShangMingCheng;
            SQlCMDpas[1].Value = dtKaiShiShiJian;
            SQlCMDpas[2].Value = dtJieShuShiJian;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDanGuanLi", SQlCMDpas);
            return dt;
        }
        public DataTable frmCaiGouDingDanGuanLi_Load_SelectCaiGouDingDan()
        {
            SqlParameter[] SQlCMDpas = {
                                             new SqlParameter("@Type", SqlDbType.Char)
                                        };
            SQlCMDpas[0].Value = "frmCaiGouDingDanGuanLi_Load_SelectCaiGouDingDan";
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDanGuanLi", SQlCMDpas);
            return dt;
        }
        #endregion
        #region 根据采购订单ID提取采购明细
        public DataTable dgvCaiGouDingDan_CellMouseClick_SelectCaiGouDingDanMingXi(int CaiGouDingDanID)
        {
            SqlParameter[] SQlCMDpas = {
                                        new SqlParameter("@Type", SqlDbType.Char),
                                        new SqlParameter("@CaiGouDingDanID", SqlDbType.Int),
                                      };
            SQlCMDpas[0].Value = "dgvCaiGouDingDan_CellMouseClick_SelectCaiGouDingDanMingXi";
            SQlCMDpas[1].Value = CaiGouDingDanID;
            DataTable dt = myDALMethod.DAL_SelectDB_Par("UIL采购管理_frmCaiGouDingDanGuanLi", SQlCMDpas);
            return dt;
        #endregion
        }
    }
}
