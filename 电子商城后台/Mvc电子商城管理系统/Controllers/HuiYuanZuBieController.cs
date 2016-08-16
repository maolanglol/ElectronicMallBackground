using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class HuiYuanZuBieController : Controller
    {

        BLL会员管理.mvcHuiYuanZuBie mymvcHuiYuanZuBie = new BLL会员管理.mvcHuiYuanZuBie();
        BLL会员管理.mvcHuiYuanZuBie_Insert mymvcHuiYuanZuBie_Insert = new BLL会员管理.mvcHuiYuanZuBie_Insert();
        BLL会员管理.mvcHuiYuanZuBie_Update mymvcHuiYuanZuBie_Update = new BLL会员管理.mvcHuiYuanZuBie_Update();


        public ActionResult HuiYuanZuBie()
        {
            return View();
        }
        #region 查询全部会员组别

        public ActionResult ChaXunQuanBuHuiYuanZuBie()
        {
            DataTable dt = mymvcHuiYuanZuBie.ChaXunQuanBuHuiYuanZuBie();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcHuiYuanZuBie_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcHuiYuanZuBie_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcHuiYuanZuBie.MoHuChaXunHuiYuanZuBie(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改会员组别信息
        //打开修改界面
        public ActionResult UpdateHuiYuanZuBie(string 会员组别ID)
        {
            Session["会员组别ID"] = Convert.ToInt32(会员组别ID);
            return View();
        }
        //根据会员ID查询会员组别
        public ActionResult ChanXunHuiYuanZuBie(string 会员组别ID)
        {
            DataTable dt = mymvcHuiYuanZuBie_Update.ChaXunHuiYuanZuBie(Convert.ToInt32(会员组别ID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiHuiYuanZuBie(string strZuBieMingCheng, string intDengJiZhi, string decChuShiJinE, string decChuShiJiFen, string decGouWuZheKou

               )
        {
            int i = mymvcHuiYuanZuBie_Update.XiuGaiHuiYuanZuBie(strZuBieMingCheng, Convert.ToInt32(intDengJiZhi), Convert.ToDecimal(decChuShiJiFen), Convert.ToDecimal(decChuShiJiFen), Convert.ToDecimal(decGouWuZheKou), Convert.ToInt32(Session["会员组别ID"]));
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

        #region 添加会员组别信息


        //打开添加界面
        public ActionResult InsertHuiYuanZuBie()
        {

            return View();
        }
        //添加会员组别信息
        public ContentResult TianJiaHuiYuanZuBie(string strZuBieMingCheng, string intDengJiZhi, string decChuShiJinE, string decChuShiJiFen, string decGouWuZheKou
                                      
            )
        {
            int i = mymvcHuiYuanZuBie_Insert.TianJiaHuiYuanZuBie(strZuBieMingCheng,Convert.ToInt32(intDengJiZhi),Convert.ToDecimal(decChuShiJiFen),Convert.ToDecimal(decChuShiJiFen),Convert.ToDecimal(decGouWuZheKou) );
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

        #region 删除会员组别信息
        //删除会员组别
        public ContentResult DeleteHuiYuanZuBie(string 会员组别ID)
        {
            int i = mymvcHuiYuanZuBie.ShanChuHuiYuanZuBie(Convert.ToInt32(会员组别ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
