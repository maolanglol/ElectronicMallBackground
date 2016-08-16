using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class YouJianMuBanController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcYouJianMuBan mymvcYouJianMuBan = new BLL会员管理.mvcYouJianMuBan();
        BLL会员管理.mvcYouJianMuBan_Insert mymvcYouJianMuBan_Insert = new BLL会员管理.mvcYouJianMuBan_Insert();
        //BLL会员管理.mvcYouJianMuBan_Update mymvcYouJianMuBan_Update = new BLL会员管理.mvcYouJianMuBan_Update();


        public ActionResult YouJianMuBan()
        {
            return View();
        }
        #region 查询全部邮件模板

        public ActionResult ChaXunQuanBuYouJianMuBan()
        {
            DataTable dt = mymvcYouJianMuBan.ChaXunQuanBuYouJianMuBan();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcYouJianMuBan_Insert.ChaXunHuiYuanDuanJinLeiXing();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanYongHuMing()
        {
            DataTable dt = mymvcYouJianMuBan_Insert.ChaXunHuiYuanYongHuMing();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcYouJianMuBan.MoHuChaXunYouJianMuBan(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion




        #region 添加邮件模板信息


        //打开添加界面
        public ActionResult InsertYouJianMuBan()
        {

            return View();
        }
        //添加邮件模板信息
        public ContentResult TianJiaYouJianMuBan(string strDiaoYongBieMing, string strBiaoTi, string strYouJianBiaoTi, string strXiTongMoRen 
            )
        {
            int i = mymvcYouJianMuBan_Insert.TianJiaYouJianMuBan( strDiaoYongBieMing,   strBiaoTi,  strYouJianBiaoTi , strXiTongMoRen );
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

        #region 删除邮件模板信息
        //删除邮件模板
        public ContentResult DeleteYouJianMuBan(string 邮件模板ID)
        {
            int i = mymvcYouJianMuBan.ShanChuYouJianMuBan(Convert.ToInt32(邮件模板ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
