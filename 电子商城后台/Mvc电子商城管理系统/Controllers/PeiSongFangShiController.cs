using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class PeiSongFangShiController : Controller
    {

        BLL销售管理.mvcPeiSongFangShi mymvcPeiSongFangShi = new BLL销售管理.mvcPeiSongFangShi();
        BLL销售管理.mvcPeiSongFangShi_Insert mymvcPeiSongFangShi_Insert = new BLL销售管理.mvcPeiSongFangShi_Insert();
        BLL销售管理.mvcPeiSongFangShi_Update mymvcPeiSongFangShi_Update = new BLL销售管理.mvcPeiSongFangShi_Update();

        public ActionResult PeiSongFangShi()
        {
            return View();
        }
        #region 查询全部配送方式

        public ActionResult ChaXunQuanBuPeiSongFangShi()
        {
            DataTable dt = mymvcPeiSongFangShi.ChaXunQuanBuPeiSongFangShi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcPeiSongFangShi_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcPeiSongFangShi_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcPeiSongFangShi.MoHuChaXunPeiSongFangShi(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改配送方式信息
        //打开修改界面
        public ActionResult UpdatePeiSongFangShi(string 配送方式ID)
        {
            Session["配送方式ID"] = Convert.ToInt32(配送方式ID);
            return View();
        }
        //根据会员ID查询配送方式
        public ActionResult ChanXunPeiSongFangShi(string 配送方式ID)
        {
            DataTable dt = mymvcPeiSongFangShi_Update.ChaXunPeiSongFangShi(Convert.ToInt32(配送方式ID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiPeiSongFangShi(string strBiaoTi, string strBeiZhu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai  )
        {
            int i = mymvcPeiSongFangShi_Update.XiuGaiPeiSongFangShi( strBiaoTi,  strBeiZhu,  strPeiSongFeiYong,  strPaiXu,  strZhuangTai, Session["配送方式ID"].ToString());
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

        #region 添加配送方式信息


        //打开添加界面
        public ActionResult InsertPeiSongFangShi()
        {

            return View();
        }
        //添加配送方式信息
        public ContentResult TianJiaPeiSongFangShi(string strBiaoTi, string strBeiZhu, string strPeiSongFeiYong, string strPaiXu, string strZhuangTai)
        {
            int i = mymvcPeiSongFangShi_Insert.TianJiaPeiSongFangShi( strBiaoTi, strBeiZhu, strPeiSongFeiYong ,  strPaiXu, strZhuangTai);
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

        #region 删除配送方式信息
        //删除配送方式
        public ContentResult DeletePeiSongFangShi(string 配送方式ID)
        {
            int i = mymvcPeiSongFangShi.ShanChuPeiSongFangShi(Convert.ToInt32(配送方式ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
