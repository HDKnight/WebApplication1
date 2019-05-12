using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo002
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            //string userName = textUserName.Text;//获得了请求中提交的数据
            //string userName = Request["textUserName"];
            string userName = Request["textUserName"];
            string userPwd = Request["textUserPwd"];

            //if (userName == "admin")
            //{
            //    msg = "OK";
            //}
            //else
            //{
            //    msg = "ERROR";
            //}
            //Response.Write(msg);


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
                Response.Write("数据库打开失败！");
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
                    //Response.Write("数据库打开成功！" + userName + " " + userPwd);
                    this.Session["currentName"] = name;
                    this.Session["currentPwd"] = pwd;
                    Server.Transfer("Main.aspx", true);
                    //this.Response.Redirect("~/Main.aspx");
                }
                else
                {
                    //context.Response.Write("密码或账号输入有误！"+name+"-"+pwd+"//"+userName+"-"+userPwd);
                    //Response.Write("密码输入不正确，请重新输入！" +
                    //    "<form action='Server.ashx' method='post'>" +
                    //    "<div>用户名：<input type='text' name='textUserName' value='" + userName + "'/></div>" +
                    //    "<div>密&#8195码：<input type='password' name='textUserPwd'/></div>" +
                    //    "<div><input type='submit' name='textSubmit' value='登录'/></div>" +
                    //    "</form> ");
                    this.ClientScript.RegisterStartupScript(
                    this.GetType(),
                    Guid.NewGuid().ToString(),
                    "alert('密码输入不正确，请重新输入！')",
                    true);
                }

            }
        }


    }
}