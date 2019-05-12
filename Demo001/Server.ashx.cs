using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Demo001
{
    /// <summary>
    /// Server 的摘要说明
    /// </summary>
    public class Server : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //获得表单中 提交 过来的 用户名
            string userName = context.Request["textUserName"];
            string userPwd = context.Request["textUserPwd"];
            //判断用户名是否存在


            //1、创建连接对象
            //2、打开数据库
            //3、执行SQL语句
            //4、读取查询结果
            //5、使用
            string connStr = "Data Source=DONG_ZI_LI;Initial Catalog=test;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch
            {
                context.Response.Write("数据库打开失败！");
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand sqlComGet = new SqlCommand();     //创建SqlCommand对象
                sqlComGet.Connection = conn;               //用sqlCon初始化SqlCommand对象
                sqlComGet.CommandText = "select * from Users where Name='" + userName + "' and Pwd='" + userPwd + "'";
                SqlDataReader sqlDr = sqlComGet.ExecuteReader();
                string name = null, pwd = null;
                while (sqlDr.Read())
                {
                    name = (string)sqlDr[1];
                    pwd = (string)sqlDr[2];
                }

                if (userName.Equals(name) && userPwd.Equals(pwd))
                {
                    context.Response.Write("数据库打开成功！" + userName + " " + userPwd);
                }
                else
                {
                    //context.Response.Write("密码或账号输入有误！"+name+"-"+pwd+"//"+userName+"-"+userPwd);
                    context.Response.Write("密码输入不正确，请重新输入！" +
                        "<form action='Server.ashx' method='post'>" +
                        "<div>用户名：<input type='text' name='textUserName' value='"+userName+"'/></div>" +
                        "<div>密&#8195码：<input type='password' name='textUserPwd'/></div>" +
                        "<div><input type='submit' name='textSubmit' value='登录'/></div>" +
                        "</form> ");
                }

            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}