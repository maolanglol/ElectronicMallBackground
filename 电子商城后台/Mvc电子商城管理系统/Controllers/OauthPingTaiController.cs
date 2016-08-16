using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class OauthPingTaiController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcOauthPingTai mymvcOauthPingTai = new BLL会员管理.mvcOauthPingTai();
        BLL会员管理.mvcOauthPingTai_Insert mymvcOauthPingTai_Insert = new BLL会员管理.mvcOauthPingTai_Insert();
        BLL会员管理.mvcOauthPingTai_Update mymvcOauthPingTai_Update = new BLL会员管理.mvcOauthPingTai_Update();


        public ActionResult OauthPingTai()
        {
            return View();
        }
        #region 查询全部OauthPingTai

        public ActionResult ChaXunQuanBuOauthPingTai()
        {
            DataTable dt = mymvcOauthPingTai.ChaXunQuanBuOauthPingTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcOauthPingTai_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcOauthPingTai_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcOauthPingTai.MoHuChaXunOauthPingTai(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改OauthPingTai信息
        //打开修改界面
        public ActionResult UpdateOauthPingTai(string OauthPingTaiID)
        {
            Session["OauthPingTaiID"] = Convert.ToInt32(OauthPingTaiID);
            return View();
        }
        //根据会员ID查询OauthPingTai
        public ActionResult ChanXunOauthPingTai(string OauthPingTaiID)
        {
            DataTable dt = mymvcOauthPingTai_Update.ChaXunOauthPingTai(Convert.ToInt32(OauthPingTaiID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiOauthPingTai(string strBiaoTi, string strMuLuMingCheng, string strMiaoShu, string strZhuangTai)
        {
            int i = mymvcOauthPingTai_Update.XiuGaiOauthPingTai( strBiaoTi,  strMuLuMingCheng,  strMiaoShu,  strZhuangTai,  Convert.ToInt32(Session["OauthPingTaiID"])
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

        #region 添加OauthPingTai信息


        //打开添加界面
        public ActionResult InsertOauthPingTai()
        {

            return View();
        }
        //添加OauthPingTai信息
        public ContentResult TianJiaOauthPingTai(string strBiaoTi, string strMuLuMingCheng, string strMiaoShu, string strZhuangTai 
            )
        {
            int i = mymvcOauthPingTai_Insert.TianJiaOauthPingTai( strBiaoTi,  strMuLuMingCheng,  strMiaoShu,  strZhuangTai   );
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

        #region 删除OauthPingTai信息
        //删除OauthPingTai
        public ContentResult DeleteOauthPingTai(string OauthPingTaiID)
        {
            int i = mymvcOauthPingTai.ShanChuOauthPingTai(Convert.ToInt32(OauthPingTaiID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
