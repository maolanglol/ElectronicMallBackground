using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class ZhiFuFangShiController : Controller
    {

        BLL销售管理.mvcZhiFuFangShi mymvcZhiFuFangShi = new BLL销售管理.mvcZhiFuFangShi();
        BLL销售管理.mvcZhiFuFangShi_Insert mymvcZhiFuFangShi_Insert = new BLL销售管理.mvcZhiFuFangShi_Insert();
        BLL销售管理.mvcZhiFuFangShi_Update mymvcZhiFuFangShi_Update = new BLL销售管理.mvcZhiFuFangShi_Update();

        public ActionResult ZhiFuFangShi()
        {
            return View();
        }
        #region 查询全部支付方式

        public ActionResult ChaXunQuanBuZhiFuFangShi()
        {
            DataTable dt = mymvcZhiFuFangShi.ChaXunQuanBuZhiFuFangShi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcZhiFuFangShi_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcZhiFuFangShi_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcZhiFuFangShi.MoHuChaXunZhiFuFangShi(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改支付方式信息
        //打开修改界面
        public ActionResult UpdateZhiFuFangShi(string 支付方式ID)
        {
            Session["支付方式ID"] = Convert.ToInt32(支付方式ID);
            return View();
        }
        //根据会员ID查询支付方式
        public ActionResult ChanXunZhiFuFangShi(string 支付方式ID)
        {
            DataTable dt = mymvcZhiFuFangShi_Update.ChaXunZhiFuFangShi(Convert.ToInt32(支付方式ID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiZhiFuFangShi(string strMingCheng, string strZhiFuMiaoShu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai )
        {
            int i = mymvcZhiFuFangShi_Update.XiuGaiZhiFuFangShi(strMingCheng, strZhiFuMiaoShu, strPeiSongFeiYong, strPaiXu, strZhuangTai, Session["支付方式ID"].ToString());
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

        #region 添加支付方式信息


        //打开添加界面
        public ActionResult InsertZhiFuFangShi()
        {

            return View();
        }
        //添加支付方式信息
        public ContentResult TianJiaZhiFuFangShi(string strMingCheng, string strZhiFuMiaoShu, string strPaiXu, string strZhuangTai)
        {
            int i = mymvcZhiFuFangShi_Insert.TianJiaZhiFuFangShi( strMingCheng,  strZhiFuMiaoShu,  strPaiXu,  strZhuangTai);
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

        #region 删除支付方式信息
        //删除支付方式
        public ContentResult DeleteZhiFuFangShi(string 支付方式ID)
        {
            int i = mymvcZhiFuFangShi.ShanChuZhiFuFangShi(Convert.ToInt32(支付方式ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
