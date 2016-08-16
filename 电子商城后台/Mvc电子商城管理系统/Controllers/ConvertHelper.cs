using System; 
using System.Collections.Generic; 
using System.Text; 
using System.Data; 
using System.Reflection; 

namespace Mvc易特进销存网页版.Controllers
{ 
        /// <summary> 
        /// 实体转换辅助类 
        /// </summary> 
        public class ConvertHelper
        {

            public static List<Dictionary<string, object>> DtToList(DataTable dt)
            {
                List<Dictionary<string, object>> ListReturn = new List<Dictionary<string, object>>();
                foreach (DataRow dr in dt.Rows)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    //遍历反射方式获取属性名和属性值
                    foreach (DataColumn dc in dt.Columns)
                    {
                        dic.Add(dc.ColumnName, dr[dc.ColumnName]);
                    }
                    ListReturn.Add(dic);

                }
                return ListReturn;
            }
        } 
} 