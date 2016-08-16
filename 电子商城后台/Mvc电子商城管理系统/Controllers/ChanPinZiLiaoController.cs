using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Text;

namespace Mvc易特进销存网页版.Controllers
{
    public class ChanPinZiLiaoController : Controller
    {
        #region 实例化逻辑层对象
        BLL基础数据.mvcChanPinZiLiao mymvcChanPinZiLiao = new BLL基础数据.mvcChanPinZiLiao();
        BLL基础数据.mvcChanPinZiLiao_Insert mymvcChanPinZiLiao_Insert = new BLL基础数据.mvcChanPinZiLiao_Insert();
        BLL基础数据.mvcChanPinZiLiao_Update mymvcChanPinZiLiao_Update = new BLL基础数据.mvcChanPinZiLiao_Update();


        #endregion
        #region 返回界面视图
        public ActionResult ChanPinZiLiao()
        {
            return View();
        }
      
        #endregion
        #region 模糊查询
       
        public ActionResult MoHuChaXun(string strMoHu)
        {

          DataTable dt=  mymvcChanPinZiLiao.MoHuChaXunWuLiao(strMoHu);

          List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

             return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 查询全部商品
      
        public ActionResult ChaXunQuanBuWuLiao()
        {
          DataTable dt=  mymvcChanPinZiLiao.ChaXunQuanBuWuLiao();


          
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
         
            return Json(ListReturn, JsonRequestBehavior.AllowGet);   
        }

        #endregion
        # region 查询商品类型

        public ActionResult ChaXunWuLiaoLeiXing()
        {
            DataTable dt = mymvcChanPinZiLiao.ChaXunWuLiaoLeiXing(); //查询所有的商品信息
         
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
        #region 按商品类别查询商品信息
       
        public ActionResult LeiBieChaXunXinXi(int WuliaoLeiXingID)
        {
            DataTable dt = mymvcChanPinZiLiao.LeiBieChaXunXinXi(WuliaoLeiXingID);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 查询仓库信息
        public ActionResult ChaXunCangKu()
        {
            DataTable dt = mymvcChanPinZiLiao_Insert.ChaXunCangKu();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 查询对应属性信息
       
        public ActionResult  ChaXunShuXing(int ShuXingJiHeID)
        {

            DataTable dt = mymvcChanPinZiLiao_Insert.ChaXunShuXing(ShuXingJiHeID);

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 查询厂商信息
      
        public ActionResult ChaXunChangShang()
        {
            DataTable dt = mymvcChanPinZiLiao_Insert.ChaXunChangShang();
            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);
            return Json(ListReturn, JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 添加商品信息
        //打开添加界面
        public ActionResult InsertWuLiao()
        {
            return View();
        }
        //保持商品信息
        public ContentResult TianJiaWuLiao( string 商品编码,
                                            string 商品名称,
                                            string 商品类别PubID,
                                            string 助记码,
                                            string 条形码,
                                            string 生产商ID,
                                            string 计量单位PubID,
                                            string 规格,
                                            string 颜色PubID,
                                            string 默认仓库ID,
                                            string 默认储位,
                                            string 打折否,
                                            string 预设进价,
                                            string VIP价格,
                                            string 会员价格,
                                            string 限售建议价格,
                                            string 备注
            )
        {
            int i = mymvcChanPinZiLiao_Insert.TianJiaWuLiao(商品编码,
                                                            商品名称,
                                                            Convert.ToInt32(商品类别PubID),
                                                            助记码,
                                                            条形码,
                                                            Convert.ToInt32( 生产商ID),
                                                            Convert.ToInt32(计量单位PubID),
                                                            规格,
                                                            Convert.ToInt32(颜色PubID),
                                                            Convert.ToInt32(默认仓库ID),
                                                            默认储位,
                                                            Convert.ToBoolean(打折否),
                                                            Convert.ToDecimal(预设进价),
                                                            Convert.ToDecimal(VIP价格),
                                                            Convert.ToDecimal(会员价格),
                                                            Convert.ToDecimal(限售建议价格),
                                                            备注);
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
        #region 修改商品信息
        //打开添加界面
        public ActionResult UpdateWuLiao(string 商品ID)
        {
            Session["商品ID"] = Convert.ToInt32(商品ID);
            return View();
        }

        public ActionResult ChanXunWuLiao(string 商品ID)
        {

            DataTable dt = mymvcChanPinZiLiao_Update.WuLiaoIDChaXunWuLiao(Convert.ToInt32(商品ID));

            List<Dictionary<string, object>> ListReturn = ConvertHelper.DtToList(dt);

            return Json(ListReturn, JsonRequestBehavior.AllowGet);

        }
        //保持商品信息
        public ContentResult XiuGaiWuLiao(  string 商品编码,
                                            string 商品名称,
                                            string 商品类别PubID,
                                            string 助记码,
                                            string 条形码,
                                            string 生产商ID,
                                            string 计量单位PubID,
                                            string 规格,
                                            string 颜色PubID,
                                            string 默认仓库ID,
                                            string 默认储位,
                                            string 打折否,
                                            string 预设进价,
                                            string VIP价格,
                                            string 会员价格,
                                            string 限售建议价格,
                                            string 备注
                                        
            )
        {
            int i = mymvcChanPinZiLiao_Update.XiuGaiWuLiao(商品编码,
                                                          商品名称,
                                                          Convert.ToInt32(商品类别PubID),
                                                          助记码,
                                                          条形码,
                                                          Convert.ToInt32(生产商ID),
                                                          Convert.ToInt32(计量单位PubID),
                                                          规格,
                                                          Convert.ToInt32(颜色PubID),
                                                          Convert.ToInt32(默认仓库ID),
                                                          默认储位,
                                                          Convert.ToBoolean(打折否),
                                                          Convert.ToDecimal(预设进价),
                                                          Convert.ToDecimal(VIP价格),
                                                          Convert.ToDecimal(会员价格),
                                                          Convert.ToDecimal(限售建议价格),
                                                          备注, 
                                                          Convert.ToInt32(Session["商品ID"]));

            return Content("true");//跳转到资料主页面
        }
        #endregion
        #region 删除商品信息
        //打开添加界面
        public ContentResult DeleteWuLiao(int 商品ID)
        {
            int i = mymvcChanPinZiLiao.ShanChuWuLiao(商品ID);
              
                return Content("true");//跳转到资料主页面
            
         
        }
        #endregion
    }
}
