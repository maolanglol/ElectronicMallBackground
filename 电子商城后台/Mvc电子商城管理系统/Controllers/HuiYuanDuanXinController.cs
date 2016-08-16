using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class HuiYuanDuanXinController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcHuiYuanDuanXin mymvcHuiYuanDuanXin = new BLL会员管理.mvcHuiYuanDuanXin();
        BLL会员管理.mvcHuiYuanDuanXin_Insert mymvcHuiYuanDuanXin_Insert = new BLL会员管理.mvcHuiYuanDuanXin_Insert();
        //BLL会员管理.mvcHuiYuanDuanXin_Update mymvcHuiYuanDuanXin_Update = new BLL会员管理.mvcHuiYuanDuanXin_Update();


        public ActionResult HuiYuanDuanXin()
        {
            return View();
        }
        #region 查询全部会员短信

        public ActionResult ChaXunQuanBuHuiYuanDuanXin()
        {
            DataTable dt = mymvcHuiYuanDuanXin.ChaXunQuanBuHuiYuanDuanXin();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcHuiYuanDuanXin_Insert.ChaXunHuiYuanDuanJinLeiXing();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanYongHuMing()
        {
            DataTable dt = mymvcHuiYuanDuanXin_Insert.ChaXunHuiYuanYongHuMing();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcHuiYuanDuanXin.MoHuChaXunHuiYuanDuanXin(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion




        #region 添加会员短信信息


        //打开添加界面
        public ActionResult InsertHuiYuanDuanXin()
        {

            return View();
        }
        //添加会员短信信息
        public ContentResult TianJiaHuiYuanDuanXin(string strDuanXinLeiXingID, string strYongHuMingID, string strBiaoTi
            )
        {
            int i = mymvcHuiYuanDuanXin_Insert.TianJiaHuiYuanDuanXin(Convert.ToInt32(strDuanXinLeiXingID), Convert.ToInt32(strYongHuMingID), strBiaoTi    );
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

        #region 删除会员短信信息
        //删除会员短信
        public ContentResult DeleteHuiYuanDuanXin(string 会员短信ID)
        {
            int i = mymvcHuiYuanDuanXin.ShanChuHuiYuanDuanXin(Convert.ToInt32(会员短信ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
