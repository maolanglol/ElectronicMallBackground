using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DALPublic
{
    public class DALMethod
    {
        //定义连接字符串
        string sqlcnnstr = @"Data Source=M2015\SQLMAOLANG,1433;Initial Catalog=MVC电子商城系统;User ID=sa;Password=123";

        #region 初始化相关ADO.NET变量
        SqlConnection sqlcn;//定义连接对象
        SqlCommand sqlcmd;//定义命令对象
        SqlDataAdapter sqlda;//定义数据适配器
        DataTable dt;//定义数据表
        #endregion

        public DataTable DAL_SelectDB_Par(string mysqlstr, SqlParameter[] SQlCMDpas)
        #region 提取数据的ADO.NET通用方法
        {
            //第一步SqlConnection：创建数据库连接类SqlConnection的对象sqlcn，好比修建湛江到广州的高速公路
            sqlcn = new SqlConnection(sqlcnnstr);
            //第二步SqlCommand A：创建命令类SqlCommand的对象sqlcmd，好比安排运输计划：运输车和货物(SQL命令)，运输通道sqlcn
            sqlcmd = new SqlCommand(mysqlstr, sqlcn);
            //第二步SqlCommand B：设置命令对象执行的SQL代码类型，此处是执行数据库中存储过程
            sqlcmd.CommandType = CommandType.StoredProcedure;

            //第二步SqlCommand C：把外部传递过来的SQL命令对应的参数填充到SqlCommand对象sqlcmd的SqlParameters集合中   
            foreach (SqlParameter var in SQlCMDpas)
            {
                sqlcmd.Parameters.Add(var);
            }

            //第三步SqlDataAdapter：用数据适配器SqlDataAdapter对象sqlda执行SqlCommand对象sqlcmd；适配器SqlDataAdapter好比高速路管理公司
            sqlda = new SqlDataAdapter(sqlcmd);//SqlDataAdapter可以隐式打开和关闭SqlConnection
            //第四步：将执行后的数据结果返回到DataTable对象dt中
            this.dt = new DataTable();
            sqlda.Fill(this.dt);
            return this.dt;
        }
        #endregion

        public int DAL_OPTableDB_Par(string mysqlstr, SqlParameter[] SQlCMDpas)
        #region   //插入、更新、删除数据库中的ADO.NET通用方法
        {
            //第一步SqlConnection：创建数据库连接类SqlConnection的对象sqlcn，并显示打开；好比修建湛江到广州的高速公路
            sqlcn = new SqlConnection(sqlcnnstr.ToString());
            sqlcn.Open();
            //第二步SqlCommand A：创建命令类SqlCommand的对象sqlcmd，好比安排运输计划：运输车和货物(SQL命令)，运输通道sqlcn
            sqlcmd = new SqlCommand(mysqlstr, sqlcn);
            //第二步SqlCommand B：设置命令对象执行的SQL代码类型，此处是执行数据库中存储过程
            sqlcmd.CommandType = CommandType.StoredProcedure;
            //第二步SqlCommand C：把外部传递过来的SQL命令对应的参数填充到SqlCommand对象sqlcmd的SqlParameters集合中   
            foreach (SqlParameter var in SQlCMDpas)
            {
                sqlcmd.Parameters.Add(var);
            }
            //第三步 SqlCommand ：SqlCommand对象sqlcmd自己执行ExecuteNonQuery()调用SQL存储过程操作数据库
            int myop = sqlcmd.ExecuteNonQuery();
            sqlcn.Close();
            return myop;
        }
        #endregion


    }
}
