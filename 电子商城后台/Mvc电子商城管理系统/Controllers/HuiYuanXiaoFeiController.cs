using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class HuiYuanXiaoFeiController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcHuiYuanXiaoFei mymvcHuiYuanXiaoFei = new BLL会员管理.mvcHuiYuanXiaoFei();
      

        public ActionResult HuiYuanXiaoFei()
        {
            return View();
        }
        #region 查询全部会员消费

        public ActionResult ChaXunQuanBuHuiYuanXiaoFei()
        {
            DataTable dt = mymvcHuiYuanXiaoFei.ChaXunQuanBuHuiYuanXiaoFei();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        
        
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcHuiYuanXiaoFei.MoHuChaXunHuiYuanXiaoFei(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        

     

        #region 删除会员消费信息
        //删除会员消费
        public ContentResult DeleteHuiYuanXiaoFei(string 会员消费ID)
        {
            int i = mymvcHuiYuanXiaoFei.ShanChuHuiYuanXiaoFei(Convert.ToInt32(会员消费ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
