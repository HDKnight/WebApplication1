using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 母版页
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = Request["UserId"];

            string connStr = "Data Source=DONG_ZI_LI;Initial Catalog=MedalSystem;Integrated Security=True";

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
                sqlComGet.CommandText = "select * from Medal_BonusPointMain where UserId='" + int.Parse(userId) + "'";
                SqlDataReader sqlDr = sqlComGet.ExecuteReader();
                string id = null;
                while (sqlDr.Read())
                {
                    id = (sqlDr[1].ToString()).Trim();
                }

                if (userId.Equals(id))
                {
                    //Response.Write("数据库打开成功！" + userName + " " + userPwd);
                    this.Session["currentId"] = id;
                    
                    Server.Transfer("index1.aspx", true);
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
                    "alert('密码输入不正确，请重新输入！"+id+" "+userId+"')",
                    true);
                }

            }
        }
    }
}