using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class HuiYuanXinXiController : Controller
    {
        //
        // GET: /HuiYuanGuanLi/


        BLL会员管理.mvcHuiYuanXinXi mymvcHuiYuanXinXi = new BLL会员管理.mvcHuiYuanXinXi();
        BLL会员管理.mvcHuiYuanXinXi_Insert mymvcHuiYuanXinXi_Insert = new BLL会员管理.mvcHuiYuanXinXi_Insert();
        BLL会员管理.mvcHuiYuanXinXi_Update mymvcHuiYuanXinXi_Update = new BLL会员管理.mvcHuiYuanXinXi_Update();


        public ActionResult HuiYuanXinXi()
        {
            return View();
        }
        #region 查询全部会员信息

        public ActionResult ChaXunQuanBuHuiYuanXinXi()
        {
            DataTable dt = mymvcHuiYuanXinXi.ChaXunQuanBuHuiYuanXinXi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员等级

        public ActionResult ChaXunHuiYuanDengJi()
        {
            DataTable dt = mymvcHuiYuanXinXi_Insert.ChaXunHuiYuanDengJi();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 查询会员状态

        public ActionResult ChaXunHuiYuanZhuangTai()
        {
            DataTable dt = mymvcHuiYuanXinXi_Insert.ChaXunHuiYuanZhuangTai();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcHuiYuanXinXi.MoHuChaXunHuiYuanXinXi(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 修改会员信息信息
        //打开修改界面
        public ActionResult UpdateHuiYuanXinXi(string 会员信息ID)
        {
            Session["会员信息ID"] = Convert.ToInt32(会员信息ID);
            return View();
        }
        //根据会员ID查询会员信息
        public ActionResult ChanXunHuiYuanXinXi(string 会员信息ID)
        {
            DataTable dt = mymvcHuiYuanXinXi_Update.ChaXunHuiYuanXinXi(Convert.ToInt32(会员信息ID));
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }


        public ContentResult XiuGaiHuiYuanXinXi(string strHuiYuanDengJiID, string strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua,string strShouJi,string strLianXiDiZhi

              )
        {
            int i = mymvcHuiYuanXinXi_Update.XiuGaiHuiYuanXinXi(Convert.ToInt32(strHuiYuanDengJiID), Convert.ToInt32(strHuiYuanZhuangTaiID), strYongHuMing, strMiMa, strNiCheng, strYouXiang, strXingBie, strQQ, strBanGongDianHua,strShouJi,strLianXiDiZhi, Convert.ToInt32(Session["会员信息ID"])
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

        #region 添加会员信息信息


        //打开添加界面
        public ActionResult InsertHuiYuanXinXi( )
        {
          
            return View();
        }
        //添加会员信息信息
        public ContentResult TianJiaHuiYuanXinXi(string strHuiYuanDengJiID, string strHuiYuanZhuangTaiID, string strYongHuMing, string strMiMa, string strNiCheng, string strYouXiang, string strXingBie, string strQQ, string strBanGongDianHua,string strShouJi,string strLianXiDiZhi
                                       
            )
        {
            int i = mymvcHuiYuanXinXi_Insert.TianJiaHuiYuanXinXi(Convert.ToInt32(strHuiYuanDengJiID), Convert.ToInt32(strHuiYuanZhuangTaiID), strYongHuMing, strMiMa, strNiCheng, strYouXiang, strXingBie, strQQ, strBanGongDianHua, strShouJi, strLianXiDiZhi
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

        #region 删除会员信息信息
        //删除会员信息
        public ContentResult DeleteHuiYuanXinXi(string 会员信息ID)
        {
            int i = mymvcHuiYuanXinXi.ShanChuHuiYuanXinXi(Convert.ToInt32(会员信息ID));
            return Content("true");//跳转到资料主页面
        }
        #endregion
    }
}
