using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class HuiYuanJiFenController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcHuiYuanJiFen mymvcHuiYuanJiFen = new BLL会员管理.mvcHuiYuanJiFen();


        public ActionResult HuiYuanJiFen()
        {
            return View();
        }
        #region 查询全部会员积分

        public ActionResult ChaXunQuanBuHuiYuanJiFen()
        {
            DataTable dt = mymvcHuiYuanJiFen.ChaXunQuanBuHuiYuanJiFen();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcHuiYuanJiFen.MoHuChaXunHuiYuanJiFen(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion






        #region 删除会员积分信息
        //删除会员积分
        public ContentResult DeleteHuiYuanJiFen(string 会员积分ID)
        {
            int i = mymvcHuiYuanJiFen.ShanChuHuiYuanJiFen(Convert.ToInt32(会员积分ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
