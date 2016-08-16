using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Mvc易特进销存网页版.Controllers
{
    public class ChanPinLeiBieController : Controller
    {
        //
        // GET: /ChanPinLeiBie/

        BLL基础数据.mvcChanPinZiLiaoLeiBie mymvcChanPinZiLiaoLeiBie = new BLL基础数据.mvcChanPinZiLiaoLeiBie();
        BLL基础数据.mvcChanPinZiLiaoLeiBie_Update mymvcChanPinZiLiaoLeiBie_Update = new BLL基础数据.mvcChanPinZiLiaoLeiBie_Update();
        BLL基础数据.mvcChanPinZiLiaoLeiBie_Insert mymvcChanPinZiLiaoLeiBie_Insert = new BLL基础数据.mvcChanPinZiLiaoLeiBie_Insert();

        public ActionResult ChanPinLeiBie()
        {
            return View();
        }
        #region 查询全部商品类别

        public ActionResult ChaXunQuanBuWuLiaoLeiBie()
        {
            DataTable dt = mymvcChanPinZiLiaoLeiBie.ChaXunQuanBuWuLiaoLeiBie();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 模糊查询

        public ActionResult MoHuChaXun(string strMoHu)
        {

            DataTable dt = mymvcChanPinZiLiaoLeiBie.MoHuChaXunWuLiaoLeiBie(strMoHu);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion

        # region 查询商品类型

        public ActionResult ChaXunWuLiaoLeiXing()
        {
            DataTable dt = mymvcChanPinZiLiaoLeiBie.ChaXunWuLiaoLeiXing(); //查询所有的商品信息

            string stringtree = GetDataString(dt, "0");//执行GetDataString方法，递归地生成树形控件要用的Json字符串
            stringtree = stringtree.Remove(stringtree.Length - 2, 2);//移除字符串最后两个字符即}，
            return Content(stringtree);//返回Joson字符串
        }
        #region　生成Tree的json数据
        public string GetDataString(DataTable dt, string id)
        {
            string stringbuilder = ""; //创建stringbuilder字符串

            DataView dv = new DataView(dt);//创建DataView对象

            dv.RowFilter = "父ID=" + id;//根据父ID=id这个条件过滤数据

            DataTable dtChild = dv.ToTable();//过滤的结果生成dtChild子数据表

            if (dtChild.Rows.Count > 0)//判断dtChild子数据表行的数量是否大于0
            { //大于0则执行下面代码
                stringbuilder += "[";  //在字符串后加上[   也可以用stringbuilder = stringbuilder+"[" 代替

                for (int i = 0; i < dtChild.Rows.Count; i++)//遍历dtChild子数据表
                {
                    string leiid = dtChild.Rows[i]["类别ID"].ToString();//把第i行的类别ID赋值给字符串leiid

                    string chidstring = GetDataString(dt, leiid);//以商品信息信息表和leiid作为参数，调用自身方法，返回Json字符串chidstring

                    if (chidstring.Length > 0)//判断chidstring字符串长度是否大于0
                    {//大于0
                        stringbuilder += "{ \"id\":\"" + dtChild.Rows[i]["类别ID"].ToString() + "\",\"text\":\"" + dtChild.Rows[i]["类别名称"].ToString().Trim() + "\",\"state\":\"closed\",\"children\":"; //除了设置id属性和text属性外，再设置state属性和children属性

                        stringbuilder += chidstring; //stringbuilder后加上chidstring字符串
                    }
                    else
                    {//等于0
                        stringbuilder += "{\"id\":\"" + dtChild.Rows[i]["类别ID"].ToString() + "\",\"text\":\"" + dtChild.Rows[i]["类别名称"].ToString().Trim() + "\"},";//设置id属性和，text属性
                    }
                }
                stringbuilder = stringbuilder.Remove(stringbuilder.Length - 1, 1);//移除字符串最后字符即,

                stringbuilder += "]},";//在字符串最后加上]},
            }
            return stringbuilder;//返回Json字符串stringbuilder
        }
        #endregion
        #endregion
        #region 修改商品类别信息
        //打开修改界面
        public ActionResult UpdateWuLiaoLeiBie(string 商品类别ID)
        {
            Session["商品类别ID"] = Convert.ToInt32(商品类别ID);
            return View();
        }


        public ActionResult ChanXunWuLiaoLeiBieID(string 商品类别ID)
        {

            DataTable dt = mymvcChanPinZiLiaoLeiBie_Update.ChaXunWuLiaoLeiBie(Convert.ToInt32(商品类别ID));

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);

        }
       
        //保持商品类别信息
        public ContentResult XiuGaiWuLiaoLeiXing(
                                string 类别名称,
                                string 父级ID,
                                string 调用别名
            )
        {
            int i = mymvcChanPinZiLiaoLeiBie_Update.XiuGaiWuLiao(Convert.ToInt32(Session["商品类别ID"]),
                                类别名称,
                              Convert.ToInt32( 父级ID),
                              调用别名              );

            return Content("true");//跳转到资料主页面
        }
        #endregion

        #region 添加商品类别信息
      

        //打开添加界面
        public ActionResult InsertWuLiaoLeiBie(string 商品类别ID)
        {
            Session["商品类别ID"] = Convert.ToInt32(商品类别ID);
            return View();
        }
        //添加商品类别信息
        public ContentResult TianJiaWuLiaoLeiBie(string 父级ID,
                                            string 类别名称,
                                            string 调用别名
            )
        {
            int i = mymvcChanPinZiLiaoLeiBie_Insert.TianJiaWuLiaoLeiBie(Convert.ToInt32(父级ID),
                                            类别名称,
                                           调用别名
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

        #region 删除商品类别信息
        //删除商品类别
        public ContentResult DeleteWuLiaoLeiBie(string 商品类别ID)
        {

            childdelete(Convert.ToInt32(商品类别ID));
          

            return Content("true");//跳转到资料主页面
        }
        #endregion

        public void childdelete(int parentID)
        {
            DataTable dtf=mymvcChanPinZiLiaoLeiBie.IDChaXunWuLiaoLeiBie(parentID);
            int rcount =dtf.Rows.Count;

            if (rcount > 0)
            {
                for (int i = 0; i < rcount; i++)
                {
                    int childID = Convert.ToInt32(dtf.Rows[i]["商品类别ID"]);
                    childdelete(childID);
                    mymvcChanPinZiLiaoLeiBie.ShanChuWuLiaoLeiBie(childID);
                }
            }
            else { return; }


        }
    }
}
