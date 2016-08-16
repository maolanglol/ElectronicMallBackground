using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class DingDanLieBiaoController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL销售管理.mvcDingDanLieBiao mymvcDingDanLieBiao = new BLL销售管理.mvcDingDanLieBiao();
        BLL销售管理.mvcDingDanLieBiao_Insert mymvcDingDanLieBiao_Insert = new BLL销售管理.mvcDingDanLieBiao_Insert();
        BLL销售管理.mvcDingDanLieBiao_Update mymvcDingDanLieBiao_Update = new BLL销售管理.mvcDingDanLieBiao_Update();


        public ActionResult DingDanLieBiao()
        {
            return View();
        }
        #region 查询全部订单信息

        public ActionResult ChaXunQuanBuDingDanLieBiao()
        {
            DataTable dt = mymvcDingDanLieBiao.ChaXunQuanBuDingDanLieBiao();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcDingDanLieBiao_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcDingDanLieBiao_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcDingDanLieBiao.MoHuChaXunDingDanLieBiao(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改订单信息信息
        //打开修改界面
        public ActionResult UpdateDingDanLieBiao(string 订单信息ID)
        {
            Session["订单信息ID"] = Convert.ToInt32(订单信息ID);
            return View();
        }
        //根据会员ID查询订单信息
        public ActionResult ChanXunDingDanLieBiao(string 订单信息ID)
        {
            DataTable dt = mymvcDingDanLieBiao_Update.ChaXunDingDanLieBiao(Convert.ToInt32(订单信息ID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiDingDanLieBiao(string strHuiYuanDengJiID, string strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua, string strShouJi, string strLianXiDiZhi

              )
        {
            int i = mymvcDingDanLieBiao_Update.XiuGaiDingDanLieBiao(Convert.ToInt32(strHuiYuanDengJiID), Convert.ToInt32(strHuiYuanZhuangTaiID), strYongHuMing, strMiMa, strNiCheng, strYouXiang, strXingBie, strQQ, strBanGongDianHua, strShouJi, strLianXiDiZhi, Convert.ToInt32(Session["订单信息ID"])
                                          );
            if (i > 0)
            {
                return Content("true");//跳转到资料主页面
            }
            else
            {
                return Content("");
            }
        }
        #endregion

        #region 添加订单信息信息


        //打开添加界面
        public ActionResult InsertDingDanLieBiao()
        {

            return View();
        }
        //添加订单信息信息
        public ContentResult TianJiaDingDanLieBiao(string strHuiYuanDengJiID, string strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua, string strShouJi, string strLianXiDiZhi

            )
        {
            int i = mymvcDingDanLieBiao_Insert.TianJiaDingDanLieBiao(Convert.ToInt32(strHuiYuanDengJiID), Convert.ToInt32(strHuiYuanZhuangTaiID), strYongHuMing, strMiMa, strNiCheng, strYouXiang, strXingBie, strQQ, strBanGongDianHua, strShouJi, strLianXiDiZhi
                                          );
            if (i > 0)
            {
                return Content("true");//跳转到资料主页面
            }
            else
            {
                return Content("");
            }
        }
        #endregion

        #region 删除订单信息信息
        //删除订单信息
        public ContentResult DeleteDingDanLieBiao(string 订单列表ID)
        {
            int i = mymvcDingDanLieBiao.ShanChuDingDanLieBiao(Convert.ToInt32(订单列表ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
